using System;
using System.Linq;

namespace ConsoleApplication1
{
    public struct Animal
    {
        public static int INDEX = 0;
        public int index;
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
            index = INDEX;
            INDEX++;
        }
        public void DisplayAnimal()
        {
            char[] name = new char[10];
            char[] naturalArea = new char[10];

            for (ushort i = 0; i < 10; ++i)
            {
                if (Name.Length < 10)
                {
                    name[i] = ' ';
                }

                else
                {
                    name[i] = Name[i];
                }

                if (NaturalZone.Length < 10)
                {
                    naturalArea[i] = ' ';
                }

                else
                {
                    naturalArea[i] = NaturalZone[i];
                }
            }
            
            Console.Write("|------|-------------|------------|------------\n|");
            Console.Write("|" + String.Format(" {0:000} |", INDEX) + String.Format(" {0:0000000000}  |", name) + String.Format(" {0:0000000000} |", naturalArea) + String.Format(" {0:0 000 000} |", Expenses));
        }
        public void SetIndex(int index)
        {
            this.index = index;
        }
    }
}