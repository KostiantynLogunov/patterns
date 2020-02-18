using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Worker
    {
        public void DoWork(IJob job)
        {
            if (job != null)
            {
                job.DoJob();
            }
        }
    }
}
