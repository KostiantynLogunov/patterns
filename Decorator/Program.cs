using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Рассмотрим пример. Допустим, у нас есть пиццерия, которая готовит различные типы пицц с различными добавками.
             * Есть итальянская, болгарская пиццы.К ним могут добавляться помидоры, сыр и т.д.
             * И в зависимости от типа пицц и комбинаций добавок пицца может иметь разную стоимость. 
             * Теперь посмотрим, как это изобразить в программе на C#:
             */


            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
            Console.WriteLine("Название: {0}", pizza1.Name);
            Console.WriteLine("Цена: {0}", pizza1.GetCost());

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
            Console.WriteLine("Название: {0}", pizza2.Name);
            Console.WriteLine("Цена: {0}", pizza2.GetCost());

            Pizza pizza3 = new BulgerianPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
            Console.WriteLine("Название: {0}", pizza3.Name);
            Console.WriteLine("Цена: {0}", pizza3.GetCost());
            Console.WriteLine("----------------------------------------------------------------");
            /*
             * Сначала объект BulgerianPizza обертывается декоратором TomatoPizza, а затем CheesePizza.
             * И таких обертываний мы можем сделать множество.Просто достаточно унаследовать от декоратора класс,
             * который будет определять дополнительный функционал.
             
             */

            /*
             *В качестве компонента здесь выступает абстрактный класс Pizza, который определяет базовую функциональность
             * в виде свойства Name и метода GetCost(). Эта функциональность реализуется двумя подклассами ItalianPizza и BulgerianPizza,
             * в которых жестко закодированы название пиццы и ее цена.
            Декоратором является абстрактный класс PizzaDecorator, который унаследован от класса Pizza и содержит ссылку
            на декорируемый объект Pizza. В отличие от формальной схемы здесь установка декорируемого объекта 
            происходит не в методе SetComponent, а в конструкторе.
            Отдельные функциональности -добавление томатов и сыры к пиццам реализованы через классы TomatoPizza и CheesePizza,
            которые обертывают объект Pizza и добавляют к его имени название добавки, а к цене - стоимость добавки,
            то есть переопределяя метод GetCost и изменяя значение свойства Name.
            */



            // next my example
            //we will make acr bmv->bmw x3, bmw x5 and than add hybrid or disel
            BMW car1 = new BmwX3();
            car1 = new BmwHybrid(car1); //bmw with hybrid engine
            Console.WriteLine("Название: {0}", car1.Name);
            Console.WriteLine("Цена: {0}K $", car1.GetCost());
            ///////////////////////////////////////////////////////////////////////////////
            BMW car15 = new BmwX3();
            car15 = new BmwElectrik(car15); //bmw with electro engine
            car15 = new BmwRedColor(car15); // bmw x5 disel wilth red color
            Console.WriteLine("Название: {0}", car15.Name);
            Console.WriteLine("Цена: {0}K $", car15.GetCost());
            ///////////////////////////////////////////////////////////////////////////////
            BMW car2 = new BmwX5();
            car2 = new BmwDisel(car2);//bmw with disel engine
            car2 = new BmwRedColor(car2); // bmw x5 disel wilth red color
            Console.WriteLine("Название: {0}", car2.Name);
            Console.WriteLine("Цена: {0}K $", car2.GetCost());
            ///////////////////////////////////////////////////////////////////////////////
            BMW car0 = new MSerries();
            car0 = new BmwBlueColor(car0); // bmw x5 disel wilth red color
            Console.WriteLine("Название: {0}", car0.Name);
            Console.WriteLine("Цена: {0}K $", car0.GetCost());

        }
    }

    abstract class Pizza
    {
        public Pizza(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }
    abstract class BMW
    {
        public string Name { get; set; }
        
        public BMW(string name)
        {
            Name = name;
        }

        public abstract int GetCost();
    }
    //==========================================================================================
    class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }

    class BmwX3 : BMW
    {
        public BmwX3() : base("BMW X3") { }

        public override int GetCost()
        {
            return 50;

        }
    }
    //==========================================================================================
    class BulgerianPizza : Pizza
    {
        public BulgerianPizza()
            : base("Болгарская пицца")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }
    
    class BmwX5 : BMW
    {
        public BmwX5() : base("BMW X5") { }

        public override int GetCost()
        {
            return 80;

        }
    }

    class MSerries : BMW
    {
        public MSerries() : base("BMW M Serries") { }

        public override int GetCost()
        {
            return 100;

        }
    }
    //==========================================================================================

    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            this.pizza = pizza;
        }
    }

    abstract class BMWDecorator : BMW
    {
        protected BMW bmw;

        protected BMWDecorator(string name, BMW car) : base(name)
        {
            bmw = car;
        }
    }
    //==========================================================================================

    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p)
            : base(p.Name + ", с томатами", p)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }
    class BmwHybrid : BMWDecorator
    {
        public BmwHybrid(BMW car) : base(car.Name + " Hybrid", car){}

        public override int GetCost()
        {
            return bmw.GetCost() + 13;
        }
    }

    class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza p)
            : base(p.Name + ", с сыром", p)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
    class BmwDisel : BMWDecorator
    {
        public BmwDisel(BMW car) : base(car.Name + " Disel", car) { }

        public override int GetCost()
        {
            return bmw.GetCost() + 3;
        }
    }
    
    class BmwRedColor : BMWDecorator
    {
        public BmwRedColor(BMW car) : base(car.Name + " RED SPORT", car) { }

        public override int GetCost()
        {
            return bmw.GetCost() + 2;
        }
    }

    class BmwBlueColor : BMWDecorator
    {
        public BmwBlueColor(BMW car) : base(car.Name + " Blue SUPER", car) { }

        public override int GetCost()
        {
            return bmw.GetCost() + 5;
        }
    }


    class BmwElectrik : BMWDecorator
    {
        public BmwElectrik(BMW car) : base(car.Name + " Electricity-new future", car) { }

        public override int GetCost()
        {
            return bmw.GetCost() + 20;
        }
    }

    //==========================================================================================

}
