using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class Logger
    {
        public void SaveLog(string message)
        {
            // seve To File message
            Console.WriteLine(message + Environment.NewLine + "saving log-data to log file..." );
        }
    }
}
