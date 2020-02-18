using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.DoWork(new HandJob());
            worker.DoWork(new FootJob());
        }
    }
}
