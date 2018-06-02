using Checkout.Core.Messaging.Abstraction;

namespace Checkout.Core.Messaging.WAMP
{
    internal class WampTransientDestination : ITransientDestination
    {
        public WampTransientDestination(string topic)
        {
            Topic = topic;
        }

        public string Topic { get; }

        public override string ToString()
        {
            return Topic;
        }
    }
}
