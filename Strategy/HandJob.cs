using System;

namespace Strategy
{
    public class HandJob : IJob
    {
        public void DoJob()
        {
            Console.WriteLine("HAND JOB");
        }
    }
}
