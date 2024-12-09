using demo_design_patterns.behavioral.Observer.Interfaces;

namespace demo_design_patterns.behavioral.Observer.Publisher
{
    public class StreamingChannel(string name) : IPublisher
    {
        public string Name = name;
        private readonly HashSet<ISubscriber> Subscribers = [];

        public void PublishToAll(string message)
        {
            foreach (var subscribe in Subscribers)
                subscribe.PostNotification(Name, message);
        }

        public void PublishToSubscriber(string message, ISubscriber subscriber)
        {
            if (Subscribers.TryGetValue(subscriber, out var sub))
                sub.PostNotification(Name, message);
        }

        public void Subscribe(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }
    }
}
