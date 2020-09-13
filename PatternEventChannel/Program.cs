using System;

namespace PatternEventChannel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var worker = new EventChannelJob();
            
            worker.run();
        }
    }
}
