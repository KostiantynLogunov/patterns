using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id)
            : base(id)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }
}
