using System;

namespace ConsoleApplication1
{
    public abstract class Rodents
    {
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public void DisplayNameClass()
        {
            Display(base.ToString());
        }
        protected void Display(string message)
        {
            Console.WriteLine(message);
        }
        public virtual void Display()
        {
            Display("Name: " + Name);
            Display("Age: " + Age.ToString());
            Display("Weight: " + Weight.ToString());
        }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return base.ToString();
            }

            return "\nName: " + Name;
        }

        public Rodents()
        {
            Display("Enter your name: ");
            Name = Console.ReadLine();
            Display("Enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Display("Enter your weight: ");
            Weight = Convert.ToInt32(Console.ReadLine());
        }
        public Rodents(string name)
        {
            Name = name;
        }
        public Rodents(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
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