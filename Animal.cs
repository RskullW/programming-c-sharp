using System;

namespace ConsoleApplication1
{
    public struct Animal
    {
        public string Name;
        public string NaturalZone;
        public float Expenses;

        public Animal(string name, string naturalZone, float expenses)
        {
            Name = name;
            NaturalZone = naturalZone;
            
            if (expenses < 0.0001)
            {
                expenses = 1;
            } 
            
            Expenses = expenses;
        }
    }
}