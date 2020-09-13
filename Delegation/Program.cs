using System;

namespace Delegation
{
    class Program
    {
        static void Main(string[] args)
        {
            var msng = new AppMessanger();

            msng.SetMessage("Hello BRO");
            msng.SetSender("Ilona");
            msng.SetRecipient("KOs");
            msng.send();
            msng.ToEmail();
            msng.send();
            msng.ToSms();
            msng.send();
        }
    }
}
