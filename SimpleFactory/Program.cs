using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var door1 = DoorFactory.MakeDoor(100, 200);
            Console.WriteLine("Door is ready!" + Environment.NewLine + "Width = " + door1.GetWidth());
            Console.WriteLine("Height = " + door1.GetHeight());
        }
    }
}
