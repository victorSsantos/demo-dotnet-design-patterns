
namespace demo_design_patterns.behavioral.Observer.Interfaces
{
    public interface ISubscriber
    {
        void PostNotification(string publisher, string message);
    }
}
