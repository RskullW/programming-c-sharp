using System;
using System.Linq;

namespace ConsoleApplication1
{
    public struct Animal
    {
        public static int INDEX = 1;
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
            string name = "";
            string naturalArea = "";

            for (ushort i = 0; i < 10; ++i)
            {
                if (i+1 > Name.Length)
                {
                    name += " ";
                }

                else
                {
                    name+=  Name[i];
                }

                if (i+1 > NaturalZone.Length)
                {
                    naturalArea+= " ";
                }

                else
                {
                    naturalArea += NaturalZone[i];
                }
            }
            
            Console.Write("|-------|------------|------------|------------|\n");
            Console.Write("|" + String.Format(" {0:00000} |", index) + name.ToString() + "  |"+ naturalArea.ToString() + "  |" + String.Format(" {0:0 000 000}  |", Expenses) + "\n");
        }
        public void SetIndex(int index)
        {
            this.index = index;
        }
    }
}