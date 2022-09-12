using System;
using System.Collections.Generic;

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
            Display("4. Output all animals");
            Display("5. Find animal");
            Display("6. Output the number of animals of a natural area");
            Display("7. Find out how much money is spent on one animal (per month)");
            Display("8. Save file");
            Display("9. Exit program");
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
            ushort numberOfItemsMenu = 9;
            ushort menuItem = 0;

            while (menuItem != numberOfItemsMenu)
            {
                DisplayMenu();
                menuItem = CorrectInput(1, numberOfItemsMenu);
                switch (menuItem)
                {
                    case 1:
                        AddAnimal();
                        break;
                    case 2:
                        DeleteAnimal();
                        break;
                    case 3:
                        ChangeAnimal();
                        break;
                    case 4:
                        OutputAllAnimals();
                        break;
                    case 5:
                        FindAnimal();
                        break;
                    case 6:
                        OutputAnimalsOfNaturalArea();
                        break;
                    case 7:
                        FindMoneyForMonthAnimal();
                        break;
                    case 8:
                        SaveFile();
                        break;
                    default: return;
                }

                StartPause();
            }
        }
        public void CloseMenu()
        {
            Display("Menu closed!");
        }
        // MENU ITEMS
        private void AddAnimal()
        {
            
        }
        
        private void DeleteAnimal()
        {
            
        }
        
        private void ChangeAnimal()
        {
            
        }
        
        private void OutputAllAnimals()
        {
            
        }
        
        private void FindAnimal()
        {
            
        }
        
        private void OutputAnimalsOfNaturalArea()
        {
            
        }
        
        private void FindMoneyForMonthAnimal()
        {
            
        }

        private void SaveFile()
        {
            LoadAnimalsInManager();
        }

        private void SaveFileFromMenu()
        {
            _managerFiles.SetAnimals(_animals);
            _managerFiles.SaveFile();
        }

        private void LoadAnimalsInManager()
        {
            _managerFiles.SetAnimals(_animals);
        }
        // CREATION
        public Manager()
        {
            _managerFiles = new ManagerFiles();
            _managerFiles.ReadFile();
            _managerFiles.OnAutoSave += LoadAnimalsInManager;
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
}