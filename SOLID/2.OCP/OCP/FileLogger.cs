using System;

namespace OCP
{
    public class FileLogger : ILogger
    {
        public void SaveLog(string message)
        {
            SaveLogToFile(message);
        }

        private void SaveLogToFile(string msg)
        {
            Console.WriteLine(msg + " => proccess of saving data-message to FILE...");
        }
    }
}
