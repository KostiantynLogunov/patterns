using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            this.State = state;
        }
        public void Request()
        {
            this.State.Handle(this);
        }
    }
}
