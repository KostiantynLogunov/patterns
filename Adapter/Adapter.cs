using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    //1 variant of creating Adapter (через наследование)
    /*class Adapter : Requester, ISender
    {
        public void Send(string msg)
        {
            this.SendRequest(msg);
        }
    }*/

    // 2 variant of creating Adapter (через екземпляр)
    class Adapter : ISender
    {
        Requester KisoClass = new Requester();
        
        public void Send(string msg)
        {
            KisoClass.SendRequest(msg);
        }
    }
}
