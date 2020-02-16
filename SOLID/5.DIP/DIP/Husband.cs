using System;

namespace DIP
{
    // зависимость от жены - ПЛОХО!
    public class Husband
    {
        public void eat()
        {
            var wife = new Wife();
            wife.getFood();
        }
    }
}
