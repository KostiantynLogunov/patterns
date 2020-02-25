using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    abstract class State
    {
        public abstract void Handle(Context context);
    }
}
