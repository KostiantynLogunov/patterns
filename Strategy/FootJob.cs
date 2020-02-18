using System;

namespace Strategy
{
    public class FootJob : IJob
    {
        public void DoJob()
        {
            Console.WriteLine("Foot Job");
        }
    }
}
