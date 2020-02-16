using System;

namespace DIP
{
    public class Wife : IFoodProvider
    {
        public void getFood()
        {
            Console.WriteLine("wife cooks food");
        }
    }
}
