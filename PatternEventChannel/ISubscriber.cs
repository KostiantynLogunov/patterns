namespace PatternEventChannel
{
    public interface ISubscriber
    {
        string Name { get; set; }
        void notify(string data);
    }
}
