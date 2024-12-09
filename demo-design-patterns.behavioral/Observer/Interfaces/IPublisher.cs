
namespace demo_design_patterns.behavioral.Observer.Interfaces
{

    public interface IPublisher
    {
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void PublishToSubscriber(string message, ISubscriber subscriber);
        void PublishToAll(string message);
    }
}
