using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /*
     * Caretaker: выполняет только функцию хранения объекта Memento,
     * в то же время у него нет полного доступа к хранителю и никаких других операций над хранителем, 
     * кроме собственно сохранения, он не производит
     */

    class Caretaker
    {
        public Memento Memento { get; set; }
    }
}
