using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.GetInstance("Привет, мир!");
            var singleton2 = Singleton.GetInstance("Здравствуй, космос!");
            Console.WriteLine(singleton2.Data);

            var ooo = new MyStat();
        }
    }


     public static class MyStat
    {

    }
}
