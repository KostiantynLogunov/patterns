using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var item = new BlogPost()
            {
                title = "Header of article",
                categoryId = 10
            };

            item.AddProperty("viewCount", "100");
            
            item.AddProperty("lastUpdate", "2030-02-01");
            item.SetProperty("lastUpdate", "2020-01-01");

            item.AddProperty("readOnly", "1");
            item.DeleteProperty("readOnly");


            Console.WriteLine("title: " + item.title);
            Console.WriteLine("categoryId " + item.categoryId);

            Console.WriteLine("viewCount: " + item.GetProperty("viewCount"));
            Console.WriteLine("lastUpdate: " + item.GetProperty("lastUpdate"));
        }
    }
}
