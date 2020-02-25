using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class StateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateA();
        }
    }
}
