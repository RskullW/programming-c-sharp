﻿namespace ConsoleApplication1
{
    public class Bat: Mouse
    {
        private float _flySpeed;
        public float FlySpeed => _flySpeed;

        public Bat() : base()
        {
            InitializeMouse();
        }
        public Bat(string name) : base(name)
        {
            InitializeMouse();
        }
        public Bat(float flySpeed) : base()
        {
            SetFlySpeed(flySpeed);
        }
        private void SetFlySpeed(float flySpeed = -1f)
        {
            if (flySpeed - _exponent <= 0f)
            {
                flySpeed = 100f;
            }

            _flySpeed = flySpeed;
        }
        public override void Display()
        {
            base.Display();
            Display("Fly speed: " + _flySpeed.ToString());
        }
        protected override void InitializeMouse()
        {
            SetFlySpeed();
        }

    }
}