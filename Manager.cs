using System;
using System.Collections.Generic;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public class Manager
    {
        private List<IMammal> _mammals;

        public void Display(string message)
        {
            Console.WriteLine(message);
        }
        private void DisplayStartMenu(ref ushort numberOfItemsMenu)
        {
            numberOfItemsMenu = 6;
            Display("Select the mammal you want to add:");
            Display("1.Bat\n2.Beaver\n3.Capybara\n4.Hamster\n5.Mouse\n6.Cat");

            if (_mammals.Count > 0)
            { 
                Display("------------------------------------------------");
                Display("Number of mammal: " + _mammals.Count.ToString());
                Display("7. Exit in Main Menu");
                numberOfItemsMenu = 7;
            }
        }

        private void DisplayMenu()
        {
            Display("1.Set condition mammal\n2.Output conditions mammal\n3.Output methods mammal\n4.Output names classes mammal\n5.Exit");
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
            ushort numberOfItemsMenu = 1;
            ushort menuItem = 0;

            while (menuItem != numberOfItemsMenu)
            {
                DisplayStartMenu(ref numberOfItemsMenu);
                menuItem = CorrectInput(1, numberOfItemsMenu);

                switch (menuItem)
                {
                    case 1:
                        _mammals.Add(new Bat());
                        break;
                    case 2:
                        Beaver beaver = new Beaver();
                        short index = FindIndexFriendHamster();
                        
                        if (index != -1)
                        {
                            beaver.SetFriendHamster(_mammals[index]);
                        }
                        
                        _mammals.Add(beaver);
                        break;
                    case 3:
                        _mammals.Add(new Capybara());
                        break;
                    case 4:
                        _mammals.Add(new Hamster());
                        break;
                    case 5:
                        _mammals.Add(new Mouse());
                        break;
                    case 6:
                        if (numberOfItemsMenu == 6)
                        {
                            StartPause();
                            return;
                        }
                        break;
                    case 7: 
                        _mammals.Add(new Cat());
                        break;
                    default: break;
                }
                
                StartPause();

            }
        }
        
        public void OpenMenu()
        {
            ushort menuItem = 0;
            ushort numberOfItemsMenu = 5;

            while (menuItem != numberOfItemsMenu)
            {
                DisplayMenu();
                menuItem = CorrectInput(1, numberOfItemsMenu);
                
                switch (menuItem) 
                {
                    case 1: SetCondition();
                        break;
                    case 2: OutputCondition();
                        break;
                    case 3: OutputMethods();
                        break;
                    case 4: OutputNameClasses();
                        break;
                    case 5: return;
                    default: break;
                }
                
                StartPause();
            }
        }
        public void CloseMenu()
        {
            Display("Menu closed!");
        }
        // CREATION
        public Manager(List<IMammal> mammals)
        {
            _mammals = mammals;
        }
        private void SetCondition()
        {
            if (_mammals == null || _mammals.Count == 0)
            {
                throw new Exception("You didn't add mammal. Warning!");
            }
            
            Display("Index selection");
            ushort indexMammal = CorrectInput(0, (ushort)(_mammals.Count - 1));
            _mammals[indexMammal].SetElements(GetNewName(), GetNewAge(), GetNewWeight());
        }
        private string GetNewName()
        {
            Display("Enter new name mammal or write \"-1\":");
            string newName = Console.ReadLine();

            if (newName == "-1")
            {
                newName = null;
            }

            return newName;
        }
        private int GetNewAge()
        {
            Display("Enter new age mammal or write \"-1\":");
            int newAge = Console.Read();

            if (newAge < 1)
            {
                newAge = -1;
            }

            return newAge;
        }
        private int GetNewWeight()
        {
            Display("Enter new weight mammal or write \"-1\":");
            int newWeight = Console.Read();

            if (newWeight < 1)
            {
                newWeight = -1;
            }

            return newWeight;
        }
        // CALL METHODS
        private void OutputMethods()
        {
            if (_mammals == null || _mammals.Count == 0)
            {
                throw new Exception("You didn't add mammal. Warning!");
            }
            
            Display("Index selection");
            ushort indexMammal = CorrectInput(0, (ushort)(_mammals.Count - 1));
            _mammals[indexMammal].StartAction();
        }

        private void OutputCondition()
        {
            if (_mammals == null || _mammals.Count == 0)
            {
                throw new Exception("You didn't add mammal. Warning!");
            }
            
            Display("Index selection");
            
            ushort indexMammal = CorrectInput(0, (ushort)(_mammals.Count - 1));
            _mammals[indexMammal].Display();
        }

        private void OutputNameClasses()
        {
            if (_mammals == null || _mammals.Count == 0)
            {
                throw new Exception("You didn't add mammal. Warning!");
            }

            foreach (var mammal in _mammals)
            {
                Display(_mammals.GetType().ToString());
            }
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
            if (_mammals == null || _mammals.Count == 0)
            {
                return false;
            }
            foreach (var _mammals in _mammals)
            {
                if (_mammals.Name == null)
                {
                    return false;
                }
            }

            return true;
        }

        private short FindIndexFriendHamster()
        {
            for (short i = 0; i < _mammals.Count; ++i)
            {
                var type = _mammals[i].GetType();
                if (type == typeof(Hamster))
                {
                    return i;
                }    
            }
            
            return -1;
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