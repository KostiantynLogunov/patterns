namespace Delegation
{
    class AppMessanger : AbstractMessanger
    {


        //default - SMS
        IMessanger obj = new SmsMessanger();
        public virtual bool send()
        {
            return obj.send();
        }

        public void ToEmail()
        {
            obj = new EmailMessanger();
        }

        public void ToSms()
        {
            obj = new SmsMessanger();
        }
    }
}
