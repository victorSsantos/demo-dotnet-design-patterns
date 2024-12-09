using demo_design_patterns.behavioral.Observer.Interfaces;

namespace demo_design_patterns.behavioral.Observer.Subscribers
{
    public class ChannelSubscriber(string name) : ISubscriber
    {
        public string Name = name;

        public void PostNotification(string channel, string message)
        {
            Console.WriteLine($"New Notification to {Name} from {channel}: {message}");
        }
    }
}
