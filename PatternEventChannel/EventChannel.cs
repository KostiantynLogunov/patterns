using System;
using System.Collections.Generic;

namespace PatternEventChannel
{
    class EventChannel : IEventChannel
    {
        private Dictionary<string, List<ISubscriber>> topics = new Dictionary<string, List<ISubscriber>>();

        public void publish(string topic, string data)
        {
            if (!topics.ContainsKey(topic) || topics[topic] == null)
            {
                Console.WriteLine($"there is error with topics by ky - {topic}");
                return;
            }

            foreach (ISubscriber subscriber in topics[topic])
            {
                subscriber.notify(data);
            }
        }

        public void subscribe(string topic, ISubscriber subscriber)
        {
            if (!topics.ContainsKey(topic))
            {
                topics.Add(topic, new List<ISubscriber>() { subscriber });
            }
            else
            {
                topics[topic].Add(subscriber);
            }


            var msg = $"{subscriber.Name} подписан на {topic}";

            Console.WriteLine(msg);
        }
    }
}
