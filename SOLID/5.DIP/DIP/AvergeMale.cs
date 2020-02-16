using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    //лучше Husband, но зависимость от жены сохраняется
    public class AvergeMale
    {
        private Wife wife;

        public AvergeMale(Wife wife)
        {
            this.wife = wife;
        }

        public void eat()
        {
            wife.getFood();
        }
    }
}
