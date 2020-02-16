using System;

namespace DIP
{
    public class Restaurant : IFoodProvider
    {
        public void getFood()
        {
            Console.WriteLine("Restaurant cooks food and delivery to home");
        }
    }
}
