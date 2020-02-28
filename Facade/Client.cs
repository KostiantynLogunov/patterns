using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Client
    {
        public void Main()
        {
            Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
            facade.Operation1();
            facade.Operation2();
        }
    }
}
