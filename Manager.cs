using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    public class Manager
    {
        private int []_numbers;
        
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
        private void DisplayMenu()
        {
            Display("1. Input array");
            Display("2. Output array");
            Display("3. Set array");
            Display("4. Exit");
        }
        
        public void StartPause()
        {
            Display("Enter any character to continue");
            var temp = Console.ReadLine();
            Console.Clear();
        }
        // MENU
        public void OpenMenu()
        {
            ushort numberOfItemsMenu = 4;
            ushort menuItem = 0;

            while (menuItem != numberOfItemsMenu)
            {
                DisplayMenu();
                menuItem = CorrectInput(1, numberOfItemsMenu);
                switch (menuItem)
                {
                    case 1:
                        NewArray.InputArray(_numbers, _numbers.Length);

                        break;
                    case 2: 
                        NewArray.OutputArray(_numbers, _numbers.Length);

                            break;
                    case 3:
                        NewArray.SetArray(_numbers, _numbers.Length);

                        break;
                    default: break;
                }

                StartPause();
            }
        }
    
        // CREATION
        public Manager()
        {
            _numbers = new int[76];
        }
        public Manager(int size)
        {
            _numbers = new int[size];
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

    }
}