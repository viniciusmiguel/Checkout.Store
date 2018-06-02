using Microsoft.Extensions.Configuration;

namespace Checkout.Core.Shared.Config
{
    internal class EventStoreConfiguration : IEventStoreConfiguration
    {
        public EventStoreConfiguration(IConfiguration eventStoreSection)
        {
            Host = eventStoreSection.GetStringValue("host", "localhost");
            Port = eventStoreSection.GetIntValue("port", 1113);
        }

        public string Host { get; }
        public int Port { get; }
    }
}
