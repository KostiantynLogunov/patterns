using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird();
            var duck = new Duck();
            var penguin = new Penguin();

            var birdRun = new BirdRun(duck);
            Console.WriteLine(birdRun.Run());
        }
    }
}
