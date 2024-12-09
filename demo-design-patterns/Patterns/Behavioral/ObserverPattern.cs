using demo_design_patterns.behavioral.Observer.Publisher;
using demo_design_patterns.behavioral.Observer.Subscribers;
using demo_design_patterns.Interfaces;

namespace demo_design_patterns.Patterns.Behavioral
{
    public class ObserverPattern : IPattern
    {
        public void ExecutePattern()
        {
            StreamingChannel YoutubeChannel = new("IT Channel");

            ChannelSubscriber subscriber1 = new("Developer 1");
            YoutubeChannel.Subscribe(subscriber1);
            YoutubeChannel.PublishToSubscriber("Thanks for subscribe the channel", subscriber1);

            ChannelSubscriber subscriber2 = new("Developer 2");
            YoutubeChannel.Subscribe(subscriber2);
            YoutubeChannel.PublishToSubscriber("Thanks for subscribe the channel", subscriber2);

            ChannelSubscriber subscriber3 = new("Developer 3");
            YoutubeChannel.Subscribe(subscriber3);
            YoutubeChannel.PublishToSubscriber("Thanks for subscribe the channel", subscriber3);

            YoutubeChannel.PublishToAll("New Tutorial posted today, enjoy it!!!");
        }
    }
}
