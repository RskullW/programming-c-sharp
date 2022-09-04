﻿using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
    public class Beaver : Rodent, IMammal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        
        private static ushort _countBeaver = 0;
        private Color _favoriteColor;
        private int _numberHeirsToThrone;
        private Hamster _bestFriendHamster;
        public int NumberHeirsToThrone => _numberHeirsToThrone;

        public Beaver() : base()
        {
            InitializeBeaver();
        }

        public Beaver(string name) : base(name)
        {
            InitializeBeaver();
        }

        public Beaver(Color color) : base()
        {
            InitializeBeaver();
        }

        public Beaver(string name, int weight, int age, Color color) : base(name, weight, age)
        {
            InitializeBeaver();
        }

        public Beaver(Beaver beaver)
        {
            
            Name = beaver.Name;
            Weight = beaver.Weight;
            Age = beaver.Age;
            _favoriteColor = beaver._favoriteColor;
            _numberHeirsToThrone = beaver._numberHeirsToThrone;
            _bestFriendHamster = beaver._bestFriendHamster;
        }
        private void PlayWithFriend()
        {
            string friendMammal = "Beaver not play";

            if (_bestFriendHamster is Hamster)
            {
                friendMammal = "Beaver plays with a hamster";
            }

            Display(friendMammal);
        }

        public void SetFavoriteColor(Color color = Color.Unknown)
        {
            ushort numberOfColor = FindCountElementsInColor();

            if (color == Color.Unknown)
            {
                Display("Enter a color(Red, Green, Blue, White, " +
                        "Black, Yellow, Brown,Pink, Orange, Grey):");

                string inputUser = Console.ReadLine();
                for (ushort index = 0; index < numberOfColor; ++index)
                {
                    color = (Color)index;

                    if (color.ToString() == inputUser)
                    {
                        break;
                    }
                }
            }

            _favoriteColor = color;
        }

        private ushort FindCountElementsInColor()
        {
            string[] tempEnumArrayString = Enum.GetNames(typeof(Color));
            return (ushort)tempEnumArrayString.Length;
        }

        private void InitializeBeaver()
        {
            _countBeaver++;
            SetFavoriteColor();
            SetNumberHeirsToThrone();
        }

        public static void ToEat()
        {
            Console.WriteLine("Nyam-nyam))) " + _countBeaver.ToString() + " beavers ate");
        }

        public void SetNumberHeirsToThrone(int numberHeirsToThrone = -1)
        {

            if (numberHeirsToThrone < 0)
            {
                numberHeirsToThrone = (int)RandomNextFloat(0, 128);
            }

            _numberHeirsToThrone = numberHeirsToThrone;
        }
        
        public void Display()
        {
            DisplayStartCondition();
            Display("Color: " + _favoriteColor);
            Display("Number heirs to the Throne: " + NumberHeirsToThrone.ToString());
            Display("Type best friend: " + _bestFriendHamster.GetType());
        }

        public void SetElements(string name = null, int age = -1, int weight = -1)
        {
            if (name != null)
            {
                Name = name;
            }
            
            if (age < 1)
            {
                Age = age;
            }

            if (weight < 1)
            {
                Weight = weight;
            }         
            
            SetFavoriteColor();
            SetNumberHeirsToThrone();
        }
        
        public void StartAction(string message = null)
        {
            ToEat();
        }

        public void SetFriendHamster(object rodent)
        {
            _bestFriendHamster = (Hamster) rodent;
            _bestFriendHamster.OnPlay += PlayWithFriend;
        }

        public void Display(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}