﻿using System;

namespace ConsoleApplication1
{
    public class Beaver : Rodents
    {
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
            _bestFriendHamster.OnPlay += PlayWithFriend;
            _countBeaver++;
            SetFavoriteColor();
            SetNumberHeirsToThrone();
        }

        public static void ToEat()
        {
            Console.WriteLine("Nyam-nyam))); " + _countBeaver.ToString() + "beavers ate");
        }

        public void SetNumberHeirsToThrone(int numberHeirsToThrone = -1)
        {
            var random = new Random();

            if (numberHeirsToThrone < 0)
            {
                numberHeirsToThrone = random.Next(0, 128);
            }

            _numberHeirsToThrone = numberHeirsToThrone;
        }
    }
}