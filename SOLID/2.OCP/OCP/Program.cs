using System;

namespace OCP
{
    /*
     * Класс должен быть открыт для расширения, но закрыт для изменения.
     * Проэктировать приложения нужно так, что бы для изменения поведения класа нам не нужно было изменять код самого класа.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var loggerDb = new DbLogger();
            var loggerFile = new FileLogger();
            
            //разное поведение записи данных в разный лог
            var product1 = new Product(loggerDb); 
            var product12 = new Product(loggerFile);

            product1.SetPriceOfProduct(13.7);
            product12.SetPriceOfProduct(117.09);

        }
    }
}
