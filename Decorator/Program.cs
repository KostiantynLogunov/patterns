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

    class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }
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

    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            this.pizza = pizza;
        }
    }

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
}
