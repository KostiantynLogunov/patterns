using System;

namespace FectoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }

    public class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }

    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }

    public interface IProduct
    {
        string Name { get; set; }
        void DoWork();
    }

    public class ConcreteProduct : IProduct
    {
        public string Name { get; set; }

        public void DoWork()
        {
            //Magic
            Console.WriteLine("created product 1");
        }
    }

    public class ConcreteProduct2 : IProduct
    {
        public string Name { get; set; }

        public void DoWork()
        {
            //Magic
            Console.WriteLine("created product 2");
        }
    }

}
