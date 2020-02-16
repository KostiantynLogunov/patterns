using System;

namespace LSP
{
    //не нарушает LSP
    public class Duck : Bird
    {
        public int fly()
        {
            var flySpeed = 8;
            return flySpeed;
        }

        public int Swim()
        {
            var swimSpeed = 4;
            return swimSpeed;
        }
    }
}
