using System;

namespace ConsoleApplication1
{
    public class Mouse: Rodents
    {
        private ConditionMammal _conditionMouse;
        private string _favoriteFood;
        private const float _exponent = 0.001f;
        
        public Mouse() : base()
        {
            InitializeBeaver();
        }
        public Mouse(string name) : base(name)
        {
            InitializeBeaver();
        }
        public Mouse(Color color) : base()
        {
            InitializeBeaver();
        }
        public Mouse(string name, int weight, int age) : base(name, weight, age)
        {
            InitializeBeaver();
        }
        public Mouse(ConditionMammal conditionMammal): base()
        {
            _conditionMouse = conditionMammal;
            SetFavoriteFood();
        }
        private void InitializeBeaver()
        {
           SetFavoriteFood();
           SetCondition();
        }
        public void SetFavoriteFood(string favoriteFood = null)
        {
            if (favoriteFood == null)
            {
                Display("Enter favorite food mouse: ");
                favoriteFood = Console.ReadLine();
            }

            _favoriteFood = favoriteFood;
        }
        public void SetCondition(Color color = Color.Unknown, float speed = 0.0f, float jumpHeight = 0.0f, ushort eatenChocolateChips = 0)
        {
            if (color == Color.Unknown)
            {
                SetColor();
            }
            
            SetSpeed(speed, 1f, 128f);
            SetJumpHeight(jumpHeight, 1f, 128f);
            _conditionMouse.EatenChocolateChips = eatenChocolateChips;
        }
        private void SetColor(Color color = Color.Unknown)
        {
            ushort numberOfColor = FindCountElementsInColor();

            if (color == Color.Unknown)
            {
                Display("Enter a color(Red, Green, Blue, White, " +
                        "Black, Yellow, Brown,Pink, Orange, Grey):");

                string inputUser = Console.ReadLine();
                for (ushort index = 0; index < numberOfColor; ++index)
                {
                    color = (Color)index;

                    if (color.ToString() == inputUser)
                    {
                        break;
                    }
                }
            }

            _conditionMouse.Color = color;
        }
        private void SetSpeed(float speed = 0.0f, float minValue = 0f, float maxValue = 1f)
        {
            if (speed - _exponent <= 0.0f)
            {
                speed = RandomNextFloat(minValue, maxValue);
            }

            _conditionMouse.Speed = speed;
        }
        private void SetJumpHeight(float jumpHeight = 0.0f, float minValue = 0f, float maxValue = 1f)
        {
            if (jumpHeight - _exponent <= 0.0f)
            {
                jumpHeight = RandomNextFloat(minValue, maxValue);
            }

            _conditionMouse.JumpHeight = jumpHeight;
        }
        private ushort FindCountElementsInColor()
        {
            string[] tempEnumArrayString = Enum.GetNames(typeof(Color));
            return (ushort)tempEnumArrayString.Length;
        }

        public virtual void StartAction(string message = null)
        {
            if (message == null)
            {
                message = "The mouse runs away from the walking cheese!!!";
            }
            
            Display(message);
        }
    }
}