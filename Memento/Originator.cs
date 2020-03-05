using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    // Originator: создает объект хранителя для сохранения своего состояния
    class Originator
    {
        public string State { get; set; }
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
        public Memento CreateMemento()
        {
            return new Memento(State);
        }
    }
}
