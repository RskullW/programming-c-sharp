using System;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public sealed class Hamster: Rodents
    {
        private Gender _gender;
        private ConditionMammal _condition;
        public event Action OnPlay;
        public Hamster() : base()
        {
            Display("Enter your Gender(Male,Female): ");
            string gender = Console.ReadLine();
            SetGender();
        }
        public Hamster(string name) : base(name)
        {
            Display("Enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Display("Enter your weight: ");
            Weight = Convert.ToInt32(Console.ReadLine());
            SetGender();
        }
        public Hamster(string name, int weight, int age) : base(name, weight, age)
        {
            SetGender();
        }
        public void RideInTheWheel()
        {
            Display("Who-o-o-o-osh!!");
        }
        protected override void SetGender()
        {
            _gender = Gender.Indefinite;
        }
        public void SetCondition()
        {
            int value = (int)RandomNextFloat(0, FindCountElementsInColor());
            Color color = (Color)(value);
            
            Display("Specify the speed of the hamster (Unit of measurement: speed of light):");
            var speed = float.Parse(Console.ReadLine());
            
            SetCondition(speed: speed);
        }
        private ushort FindCountElementsInColor()
        {
            string[] tempEnumArrayString = Enum.GetNames(typeof(Color));
            return (ushort) tempEnumArrayString.Length;
        }
        private void SetCondition(Color color = Color.Black, float speed = 0f, float JumpHeight = 0f)
        {
            _condition = new ConditionMammal(color);
            _condition.Speed = speed;
            _condition.JumpHeight = speed / 4;
            _condition.EatenChocolateChips++;
        }
        public void PlayWithFriend()
        {
            OnPlay?.Invoke();
        }

        public override void Display()
        {
            base.Display();
            Display("Gender: " + _gender.ToString());
            Display("Color: " + _condition.Color.ToString() + "\nSpeed: " + _condition.Speed);
            Display("Jump Height" + _condition.JumpHeight + "\nNumber of eaten chocolate chips:" +
                    _condition.EatenChocolateChips);
        }
    }
}