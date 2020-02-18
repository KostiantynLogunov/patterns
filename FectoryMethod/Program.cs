using FectoryMethod.Factories;
using FectoryMethod.Games;
using System;

namespace FectoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIRST EXAMPLE
            /*
                        IBidloFactory[] lvls = new IBidloFactory[] { // инициализируем уровни сложности, пользователь будет их выбирать
                            new EzLvlBidloFactory(),
                            new MidleLvlBidloFactory(),
                            new HardLvlBidloFactory()
                        };

                        Console.WriteLine("Выберете уровень сложности и введите его номер:");

                        for (int i = 0; i < lvls.Length; i++) // выведем все уровни сложности пользователю
                        {
                            Console.WriteLine($"{i + 1}. {lvls[i].ToString()}"); // i+1 потому что нормальные люди считают с 1, а не с 0
                        }

                        int lvlNumber = Convert.ToInt32(Console.ReadLine()) - 1; // -1 потому что нормальные люди всё ещё считают с 1)))

                        if (lvlNumber > -1 && lvlNumber < lvls.Length) // проверяем находится ли число в пределах массива
                        {
                            Game game = new Game(lvls[lvlNumber]); // создаём игру с выбранным уровнем сложности
                            game.StartGame();
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое число");
                        }
            */

            //SECOND EXAMPLE
            var messanger = new TestMessanger("Kostia", "123456"); // НИКОГДА не используйте такой пароль!!!
            messanger.SendMessage("Hello, World!", "Kostia", "Ilona");

            var twitter = new TwitterMessanger("Kostia", "123456");
            var twit = twitter.CreateMessage("Hi, Bro!", "Kostia", "Ilona");
            twit.Send();

            var instagram = new InstagramMessanger("Kostia", "123456");
            var photo = instagram.CreateMessage("win.jpg", "Kostia", "Ilona");
            photo.Send();

            var telegram = new TelegramMessanger("Kostia", "123456");
            var text = telegram.CreateMessage("Hi, Man!", "Kostia", "Ilona");
            text.Send();



                                // GENERAL CASE

            // Создаем конкретного создателя и помещаем его в обобщенного создателя.
            // Обратите внимание, что конкретных создателей может быть много,
            // но за счет полиморфизма их можно помещать в базовый тип создателя
            // и работать с ними обособившись от конкретных реализаций.
            Creator creator = new ConcreteCreator();
            Creator creator2 = new ConcreteCreator2();

            // Создаем конкретный продукт и помещаем его в обобщенный продукт.
            // Обратите внимание, что мы работаем с обобщенным создателем и обобщенным продуктом,
            // но за счет полиморфизма будет вызываться реализация конкретного создатели 
            // и получен конкретный продукт, но он будет помещен в обобщенный продукт.
            // Это позволит нам работать с продуктами обособившись от конкретных реализаций.
            IProduct product = creator.FactoryMethod();
            IProduct product2 = creator2.FactoryMethod();

            // Вызываем какое-либо действие обобщенного продукта, 
            // но за счет полиморфизма будет вызываться реализация этого метода в конкретном продукте.
            product.DoWork();
            product2.DoWork();
        }
    }
}
