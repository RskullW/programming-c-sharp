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
        private void DisplaySecondMenu()
        {
            Display("Choose the key factor by which you will search for items");
            Display("1. Index");
            Display("2. Name");
            Display("3. Exit");
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
                        SaveFileFromMenu();
                        break;
                    default: break;
                }

                StartPause();
            }
        }
        public void CloseMenu()
        {
            _managerFiles.CloseManager();
            Display("Menu closed!");
        }
        private void OpenSecondMenu()
        {
            ushort numberOfItemsMenu = 3;
            ushort menuItem = 0;
            Animal[] animalsArray = _animals.ToArray();

            if (_animals.Count < 1)
            {
                Display("Sorry, not available animals");
                return;
            }

            DisplaySecondMenu();
            menuItem = CorrectInput(1, numberOfItemsMenu);
            switch (menuItem)
            {
                case 1:
                    FindIndexAnimals(animalsArray);
                    break;
                case 2:
                    FindNameAnimal(animalsArray);
                    break;
                default: break;
            }
        }
        // MENU ITEMS
        private void AddAnimal()
        {
            string name = CreateName();
            string naturalArea = CreateNaturalArea();
            float expenses = CreateExpenses();

            _animals.Enqueue(new Animal(name, naturalArea, expenses));
        }
        private void DeleteAnimal(short index = -1)
        {
            
            if (_animals.Count < 1)
            {
                Display("Sorry, but there are no animals on the list");
                return;
            }

            if (index == -1)
            {
                Display("Entering an index");
                index = (short)CorrectInput(0, (ushort)(_animals.Count-1));
            }

            Animal[] animalsArray = _animals.ToArray();
            Queue<Animal> newAnimal = new Queue<Animal>();
            for (ushort i = 0; i < _animals.Count; ++i)
            {
                if (i == index)
                {
                    continue;
                }
                
                animalsArray[i].SetIndex(i);
                newAnimal.Enqueue(animalsArray[i]);
            }

            Animal.INDEX--;
            _animals = newAnimal;
        }
        private void ChangeAnimal()
        {
            Display("Entering an index");
            short index = (short)CorrectInput(0, (ushort)(_animals.Count - 1));
            DeleteAnimal(index);

            Animal[] animalsArray = _animals.ToArray();

            for (short i = 0; i < animalsArray.Length; ++i)
            {
                if (i == index)
                {
                    animalsArray[index].Name = CreateName();
                    animalsArray[index].NaturalArea = CreateNaturalArea();
                    animalsArray[index].Expenses = CreateExpenses();

                    break;
                }
            }

            _animals = new Queue<Animal>(animalsArray);
        }
        private void OutputAllAnimals()
        {
            Animal[] animalsArray = _animals.ToArray();

            if (animalsArray.Length < 1)
            {
                Display("Table empty");
                return;
            }

            DisplayNameTable();
            foreach (var animal in animalsArray)
            {
                animal.DisplayAnimal();
            }
        }
        private void FindAnimal()
        {
            OpenSecondMenu();
        }
        private void OutputAnimalsOfNaturalArea()
        {
            Display("Entering an index");
            string naturalArea = CreateNaturalArea();

            Animal[] animalsArray = _animals.ToArray();
            
            DisplayNameTable();
            
            foreach (var animal in animalsArray)
            {
                animal.DisplayAnimal();
            }
        }
        private void FindMoneyForMonthAnimal()
        {
            Display("Entering an index");
            ushort index = CorrectInput(0, (ushort)(_animals.Count-1));

            Animal[] animalsArray = _animals.ToArray();
            
            Display("Costs per month for \"" + animalsArray[index].Name + "\" = " + animalsArray[index].Expenses*30);
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
        private string CreateName()
        {
            Display("Enter name animal");
            return Console.ReadLine();
        }
        private string CreateNaturalArea()
        {
            Display("Enter natural area");
            
            string naturalArea = Console.ReadLine();
            naturalArea = naturalArea.ToLower();
            
            return naturalArea;
        }
        private float CreateExpenses()
        {
            Display("Enter expenses animal");
            return float.Parse(Console.ReadLine() ?? "0");
        }
        // CORRECTNESS
        private ushort CorrectInput(ushort minValue = 0, ushort maxValue = 1)
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
        // Auxiliary methods
        private void DisplayNameTable()
        {
            Console.WriteLine("|-INDEX-|----NAME----|NATURAL-AREA|--EXPENSES--|\n");
        }
        private void FindIndexAnimals(Animal[] animalsArray)
        {
            ushort index = CorrectInput(0, (ushort)(_animals.Count-1));
                        
            foreach (var animal in animalsArray)
            {
                if (animal.index == index)
                {
                    DisplayNameTable();
                    animal.DisplayAnimal();
                    break;
                }
            }
        }
        private void FindNameAnimal(Animal[] animalsArray)
        {
            string name = CreateName();
            
            foreach (var animal in animalsArray)
            {
                if (animal.Name == name)
                {
                    DisplayNameTable();
                    animal.DisplayAnimal();
                    break;
                }
            }
        }
    }
}