namespace PatternEventChannel
{
    //интерфейс канала событий
    //связующее звено между попищиком и издателем
    public interface IEventChannel
    {
        /*
         * издатель уведомляет канал о том что надо всех кто подписан на тему topic уведомить даним data
         */
        void publish(string topic, string data);

        /*
         * подпищик subscriber подписывается на собитие topic
         */
        void subscribe(string topic, ISubscriber subscriber);
    }
}
