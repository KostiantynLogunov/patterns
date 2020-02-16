using System;

namespace OCP
{
    public class DbLogger : ILogger
    {
        public void SaveLog(string message)
        {
            SaveLogToDb(message);
        }

        private void SaveLogToDb(string msg)
        {
            Console.WriteLine(msg + " => proccess of saving data-message to DATABASE...");
        }
    }
}
