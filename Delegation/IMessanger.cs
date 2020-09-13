namespace Delegation
{
    interface IMessanger
    {
        void SetSender(string value);
        void SetRecipient(string value);
        void SetMessage(string value);
        bool send();
    }
}
