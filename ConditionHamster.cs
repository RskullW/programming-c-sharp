using System;

namespace ConsoleApplication1
{
    [Serializable]
    public struct ConditionHamster
    {
        public Color Color;
        public float Speed;
        public float JumpHeight;
        public ushort EatenChocolateChips;

        public ConditionHamster(Color color)
        {
            Color = color;
            Speed = 1337.228f;
            JumpHeight = 256.01f;
            EatenChocolateChips = 0;
        }
    }
}