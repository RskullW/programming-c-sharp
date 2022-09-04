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
        
    }
}