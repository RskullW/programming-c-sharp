using System;
using System.Collections.Generic;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public class Manager
    {
        private Queue<Animal> _animals;
        private ManagerFiles _managerFiles;
        
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
        private void DisplayStartMenu(ref ushort numberOfItemsMenu)
        {
        }
        private void DisplayMenu()
        {
            Display("Number of animals: " + _animals.Count.ToString());
            Display("______________________");
            Display("1. Add a new animal");
            Display("2. Delete animal");
            Display("3. Change animal");
            Display("4. Find animal");
            Display("5. Output the number of animals of a natural area");
            Display("6. Find out how much money is spent on one animal (per month)");
            Display("7. Save file");
            Display("8. Exit program");
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
            
        }
        public void CloseMenu()
        {
            Display("Menu closed!");
        }
        // CREATION
        public Manager()
        {
            _managerFiles = new ManagerFiles();
            _managerFiles.ReadFile();
            _animals = _managerFiles.GetAnimals();
            
            _managerFiles.StartAutoSave();
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
    
    /*
     * ‒ задание свойств каждого объекта; (хотя бы по одному объекту 
на не абстрактный класс);
‒ вывод свойств объекта;
‒ выполнение методов объекта;
‒ вывод имени класса объекта
     */
}