using Checkout.Core.Shared.Config;

namespace Checkout.Core.Messaging
{
    public static class BrokerConnectionFactory
    {
        public static BrokerConnection Create(IBrokerConfiguration config)
        {
            return new BrokerConnection(BrokerUri.FromConfig(config), config.Realm);
        }
    }
}
