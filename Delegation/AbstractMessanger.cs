using System;

namespace Delegation
{
    class AbstractMessanger : IMessanger
    {
        protected string message { get; set; } = "not set";
        protected string recipient { get; set; } = "not set";
        protected string sender { get; set; } = "not set";

        public virtual bool send()
        {
            Console.WriteLine($"Author: {sender}  --   SEND MSG: [{message}] --- to {recipient} --- by " + this.GetType().Name);
            return true;
        }

        public void SetMessage(string value)
        {
            message = value;
        }

        public void SetRecipient(string value)
        {
            recipient = value;
        }

        public void SetSender(string value)
        {
            sender = value;
        }
    }
}
