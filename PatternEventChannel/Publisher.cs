namespace PatternEventChannel
{
    public class Publisher : IPublisher
    {
        private string _topic { get; set; }
        private IEventChannel _eventChannel { get; set; }

        public Publisher(string topic, IEventChannel eventChannel)
        {
            _topic = topic;
            _eventChannel = eventChannel;
        }
       
        public void piblish(string data)
        {
            _eventChannel.publish(_topic, data);
        }
    }
}
