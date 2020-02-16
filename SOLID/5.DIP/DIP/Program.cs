using System;

namespace DIP
{
    //Зависимости должны строиться относительно абстракций но не деталей(класов). Тоесть можно сделать зависимость от интерфейсов.
    class Program
    {
        static void Main(string[] args)
        {
            var woman = new Wife();
            var cafe = new Restaurant();

            var man1 = new HighMale(woman);
            var man2 = new HighMale(cafe);

            man1.eat();
            man2.eat();
        }
    }
}
