using System;

namespace SRP
{
    /*Любий обєкт  повинен мати лише один обовязок і цей обовязок повністю реалізован в класі.
        АБО
    Існує лише одна причина, яка приводить до зміни класу*/
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            var product = new Product(logger);

            product.SetPrice(100.5);
        }
    }
}
