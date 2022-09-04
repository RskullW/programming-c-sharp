using System;

namespace ConsoleApplication1
{
    public abstract class Rodent
    {
        private string _name { get; set; }
        private int _age { get; set; }
        private int _weight { get; set; }

        public string DisplayNameClass()
        {
            return base.ToString();
        }

        private void Display(string message)
        {
            Console.WriteLine(message);
        }
        protected void DisplayStartCondition()
        {
            Display("Name: " + _name);
            Display("Age: " + _age.ToString());
            Display("Weight: " + _weight.ToString());
        }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(_name))
            {
                return base.ToString();
            }

            return "\nName: " + _name;
        }

        public Rodent()
        {
            Display("Enter your name: ");
            _name = Console.ReadLine();
            Display("Enter your age: ");
            _age= Convert.ToInt32(Console.ReadLine());
            Display("Enter your weight: ");
            _weight = Convert.ToInt32(Console.ReadLine());
        }
        public Rodent(string name)
        {
            _name = name;
        }
        public Rodent(string name, int weight, int age)
        {
            _name = name;
            _weight = weight;
            _age = age;
        }
        protected float RandomNextFloat(float minValue = 0f, float maxValue = 1f)
        {
            var random = new Random();
            return (float)(random.NextDouble() * ( maxValue- minValue)) + minValue;
        }
        protected virtual void SetGender()
        {
            Display("Gender is not defined");
        }
    }
}