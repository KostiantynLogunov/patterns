using System;

namespace LSP
{
    //нарушает LSP так как нарушает поведение
    public class Penguin : Bird
    {
        public string fly()
        {
            Console.WriteLine("Penguin can not fly !"); //не тепичное поведение
            return "Penguin can not fly !";//не тепичное поведение
        }

        public int Swim()
        {
            var swimSpeed = 8;
            return swimSpeed;
        }
    }
}
