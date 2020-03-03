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
            /*
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
            */


            // GENERAL CASE

            // Создаем конкретного создателя и помещаем его в обобщенного создателя.
            // Обратите внимание, что конкретных создателей может быть много,
            // но за счет полиморфизма их можно помещать в базовый тип создателя
            // и работать с ними обособившись от конкретных реализаций.
            /*
             *Creator creator = new ConcreteCreator();
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
             */


            // NEXT EXAMPLE
            /*
             * В качестве абстрактного класса Product здесь выступает класс House.Его две конкретные реализации -
             * PanelHouse и WoodHouse представляют типы домов, которые будут строить подрядчики. 
             * В качестве абстрактного класса создателя выступает Developer, определяющий абстрактный метод Create().
             * Этот метод реализуется в классах - наследниках WoodDeveloper и PanelDeveloper.
             * И если в будущем нам потребуется построить дома какого - то другого типа, например, кирпичные, 
             * то мы можем с легкостью создать новый класс кирпичных домов, унаследованный от House,
             * и определить класс соответствующего подрядчика.Таким образом, система получится легко расширяемой.
             * Правда, недостатки паттерна тоже очевидны -для каждого нового продукта необходимо создавать свой класс создателя.
             */
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            House house = dev.Create();
        }
    }

    // абстрактный класс строительной компании
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public House Create();
    }
    // строит панельные дома
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
    // строит деревянные дома
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    abstract class House
    { }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}
