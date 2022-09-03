using System;
using System.Collections.Generic;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public class ManagerCapybaras
    {
        private List<Capybara> _capybaras;

        public void Display(string message)
        {
            Console.WriteLine(message);
        }
        private void DisplayMenu(ref ushort numberOfItemsMenu)
        {
            Display("Numbers of Capybaras: " + _capybaras.Count);
            Display("1. Create capybara");
            
            if (CheckForExistence())
            {
                numberOfItemsMenu = 6;
                Display("2. Set parameters");
                Display("3. Output condition objects.");
                Display("4. Call statical methods.");
                Display("5. Call methods object");
                Display("6. Exit");
            }

            else
            {
                Display("2. Exit");
            }
        }
        private void DisplaySecondMenu(ushort indexCapybara)
        {
            Display("Numbers of Capybaras: " + _capybaras.Count);
            Display("Index of the selected capybara: " + indexCapybara.ToString());
            Display("1.Kapibaritsya\n2.Scratch\n3.Swim\n4.ToString()\n5.Exit");
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
            ushort numberOfItemsMenu = 2;
            ushort menuItem = 0;

            while (menuItem!=numberOfItemsMenu)
            {
                DisplayMenu(ref numberOfItemsMenu);
                menuItem = CorrectInput(1, numberOfItemsMenu);
                if (numberOfItemsMenu == 2)
                {
                    switch (menuItem)
                    {
                        case 1: CreateCapybara(); break; 
                        default: return;
                    }
                    
                    StartPause();
                    continue;
                }

                switch (menuItem)
                {
                    case 1: CreateCapybara(); break;
                    case 2: SetParameters(); break;
                    case 3: OutputCondition(); break;
                    case 4: CallStaticMethods(); break;
                    case 5: CallMethodsObjects(); break;
                    
                    default: return;
                }
                
                StartPause();
            }
        }
        private void OpenSecondMenu()
        {
            ushort numberOfItemsMenu = 5;
            ushort menuItem = 0;
            ushort indexCapybara = ChooseCapybaras();

            while (menuItem == 0)
            {
                Console.Clear();
                DisplaySecondMenu(indexCapybara);
                menuItem = CorrectInput(0, numberOfItemsMenu);
                switch (menuItem)
                {
                    case 1:
                        _capybaras[indexCapybara].Kapibaritsya();
                        break;
                    case 2:
                        _capybaras[indexCapybara].Scratch();
                        break;
                    case 3:
                        _capybaras[indexCapybara].Swim();
                        break;
                    case 4:
                        Display("ToString: " + _capybaras[indexCapybara].ToString());
                        break;

                    default: return;
                }
            }
        }
        // CREATION
        public ManagerCapybaras(List<Capybara> capybaras)
        {
            _capybaras = capybaras;
        }
        private void CreateCapybara()
        {
            var random = new Random();
            ushort variable = (ushort)random.Next(0, 3);
            switch (variable)
            {
                case 0:
                    _capybaras.Add(new Capybara());
                    break;
                case 1:
                    _capybaras.Add(new Capybara(CreateGender()));
                    break;
                case 2:
                    _capybaras.Add(new Capybara(CreateName()));
                    break;
                default:
                    _capybaras.Add(new Capybara(CreateName(), gender: CreateGender(), weight: CreateWeight(),
                        age: CreateAge()));
                    break;
            }
        }
        private ushort CreateWeight()
        {
            Display("Enter capybara weight");
            return CorrectInput(0, 210);
            
        }
        private ushort CreateAge()
        {
            Display("Enter capybara age");
            return CorrectInput(0, 69);
        }
        private Gender CreateGender()
        {
            string genderString;
            Gender gender = Gender.Indefinite;

            Display("Set the gender of the new capybara(Male, Female):");
            genderString = Console.ReadLine();

            if (genderString == Gender.Male.ToString())
            {
                gender = Gender.Male;
            }

            else if (genderString == Gender.Female.ToString())
            {
                gender = Gender.Female;
            }

            return gender;
        }
        private string CreateName()
        {
            Display("Enter capybara name");
            return Console.ReadLine();
        }
        private void SetParameters()
        {
            var indexCapybaras = ChooseCapybaras();
            ushort choise;
            
            Display("Choose what to change:\n1. Name\n2. Age\n3. Weight\n4.Exit");
            choise = CorrectInput(1, 4);

            switch (choise)
            {
                case 1: _capybaras[indexCapybaras].Name = CreateName(); break;
                case 2: _capybaras[indexCapybaras].Age = CreateAge(); break;
                case 3: _capybaras[indexCapybaras].Weight = CreateWeight(); break;
                default: break;
            }
        }
        // CALL METHODS
        private void OutputCondition()
        {
            if (_capybaras != null)
            {
                foreach (var capybara in _capybaras)
                {
                    capybara.Display();
                }
            }

            else
            {
                throw new Exception("Capybaras don't exist!");
            }
        }
        private void CallStaticMethods()
        {
            Display(Capybara.GetAdvice());
        }
        private ushort ChooseCapybaras()
        {
            if (_capybaras == null)
            {
                throw new Exception("Capybaras don't exist!");
            }
            
            Display("CHOOSING A CAPYBARA");
            return CorrectInput(0, (ushort)(_capybaras.Count - 1));;
        }
        private void CallMethodsObjects()
        {
            OpenSecondMenu();
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
            if (_capybaras == null || _capybaras.Count == 0)
            {
                return false;
            }
            foreach (var capybara in _capybaras)
            {
                if (capybara.Name == null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}