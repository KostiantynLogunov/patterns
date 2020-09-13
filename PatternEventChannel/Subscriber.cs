using System;

namespace PatternEventChannel
{
    public class Subscriber: ISubscriber
    {
        public string Name { get; set; }
        public Subscriber(string name)
        {
            Name = name;
        }

        public void notify(string data)
        {
            var msg = $"{Name} got message: {data}";
            Console.WriteLine(msg);
        }
    }
}
