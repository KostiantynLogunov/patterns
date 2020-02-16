using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    //зависимости от класа больше нет! Только зависимость от абстракции.
    public class HighMale
    {
        private IFoodProvider foodProvider;

        public HighMale(IFoodProvider foodProvider)
        {
            this.foodProvider = foodProvider;
        }

        public void eat()
        {
            foodProvider.getFood();
        }
    }
}
