using System;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public sealed class Capybara : Rodents
    {
        private static string _advice;
        private bool _harmful;
        private Gender _gender;
        public bool Harmful => _harmful;
        protected override void SetGender()
        {
            Display("Enter your Gender(Male,Female): ");
            string gender = Console.ReadLine();
            
            _gender = Gender.Indefinite;
            
            if (gender == Gender.Male.ToString())
            {
                _gender = Gender.Male;
            }
            
            else if (gender == Gender.Female.ToString())
            {
                _gender = Gender.Female;
            }
            
            switch (_gender)
            {
                case Gender.Female:
                    _harmful = true;
                    break;
                case Gender.Male:
                    _harmful = false;
                    break;
                default:
                    throw new Exception("The genus is not defined. Remember, there are only 2 genders in biology.");
            }
        }
        public void Kapibaritsya()
        {
            Console.WriteLine("The capybara has gone crazy");
        }
        public void Swim()
        {
            Console.WriteLine("Bul-bul-bul");
        }
        public void Scratch()
        {
            Console.WriteLine("Capybara scratches the back");
        }
        private static void GenerateAdvice()
        {
            var random = new Random();
            _advice = "Save up $" + random.Next(1, Int32.MaxValue) + " to go to Israel";
        }
        public static string GetAdvice()
        {
            GenerateAdvice();
            return _advice;
        }
        public override void Display()
        {
            base.Display();
            Display("Gender: " + _gender.ToString());
        }
        public Capybara(): base()
        {
            SetGender();
        }
        public Capybara(Gender gender): base()
        {
            _harmful = false;

            _gender = gender;
            if (_gender == Gender.Female)
            {
                _harmful = true;
            }
        }
        public Capybara(string name): base(name)
        {
            Display("Enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Display("Enter your weight: ");
            Weight = Convert.ToInt32(Console.ReadLine());
            SetGender();
        }
        public Capybara(string name, int weight, int age, Gender gender): base(name, weight, age)
        {
            _harmful = false;
            _gender = gender;
            
            if (_gender == Gender.Female)
            {
                _harmful = true;
            }
        }
        public static bool operator true(Capybara capybara)
        {
            if (capybara._gender == Gender.Male)
            {
                return true;
            }

            return false;
        }
        public static bool operator false(Capybara capybara)
        {
            if (capybara._gender == Gender.Female)
            {
                return false;
            }

            return true;
        }
        public static Capybara operator +(Capybara capybara1, Capybara capybara2)
        {
            string name = capybara1.Name + " " + capybara2.Name;
            int age = capybara1.Age + capybara2.Age;
            int weight = capybara1.Weight = capybara2.Weight;
            Gender gender = Gender.Indefinite;

            return new Capybara(name, weight, age, gender);
        }
    }
}