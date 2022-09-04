using System;
using System.Collections.Generic;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public class Manager
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
        private void DisplayStartMenu(ref ushort numberOfItemsMenu)
        {
        }

        private void DisplayMenu()
        {
        }
        public void StartPause()
        {
            Display("Enter any character to continue");
            var temp = Console.ReadLine();
            Console.Clear();
        }
        // MENU
        public void OpenStartMenu()
        {
        }
        
        public void OpenMenu()
        {
            
        }
        public void CloseMenu()
        {
            Display("Menu closed!");
        }
        // CREATION
        public Manager()
        {
            
        }
        // CORRECTNESS
        public ushort CorrectInput(ushort minValue = 0, ushort maxValue = 1)
        {
            string numberString = "0";
            ushort number;
            Display("Enter a number from " + minValue.ToString() + " to " + maxValue.ToString());

            numberString = Console.ReadLine();
            
            number = ushort.Parse(numberString);

            if (number < minValue || number > maxValue)
            {
                number = 0;
            }

            return number;
        }
        private bool CheckForExistence()
        {
            return true;
        }
    }
    
    /*
     * ‒ задание свойств каждого объекта; (хотя бы по одному объекту 
на не абстрактный класс);
‒ вывод свойств объекта;
‒ выполнение методов объекта;
‒ вывод имени класса объекта
     */
}