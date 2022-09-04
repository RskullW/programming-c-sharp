using System;

namespace ConsoleApplication1
{
    public class Cat: IMammal
    {
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }
        private float _power;

        public Cat()
        {
            InitializeCat();
            SetPower();
        }

        public Cat(float power)
        {
            InitializeCat();
            _power = power;

        }
        public Cat(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            SetPower();
        }

        private void InitializeCat()
        {
            Display("Enter your name: ");
            Name = Console.ReadLine();
            Display("Enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Display("Enter your weight: ");
            Weight = Convert.ToInt32(Console.ReadLine());   
        }
        public void SetPower()
        {
            var random = new Random();
            _power = random.Next(0, 100000);
        }
        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public void StartAction(string message = null)
        {
            Display("MEOOOOOOOOOOOOOOOOOOOOOOOW-MEEEEOW-MEEOW-MEOW-MEW-MW-M");    
        }

        public void SetElements(string name, int age, int weight)
        {
            
            Display("Enter your name: ");
            Name = Console.ReadLine();
            Display("Enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Display("Enter your weight: ");
            Weight = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            DisplayStartCondition();
        }
        
        private void DisplayStartCondition()
        {
            Display("Name: " + Name);
            Display("Age: " + Age.ToString());
            Display("Weight: " + Weight.ToString());
            Display("Power: " + _power);
        }
    }
}