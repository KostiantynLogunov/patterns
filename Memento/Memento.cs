using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /*
     Memento: хранитель, который сохраняет состояние объекта Originator и 
     предоставляет полный доступ только этому объекту Originator
         */
    class Memento
    {
        public string State { get; private set; }
        public Memento(string state)
        {
            this.State = state;
        }
    }
}
