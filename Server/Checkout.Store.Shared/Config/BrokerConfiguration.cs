using Microsoft.Extensions.Configuration;

namespace Checkout.Core.Shared.Config
{
    internal class BrokerConfiguration : IBrokerConfiguration
    {
        public BrokerConfiguration(IConfiguration brokerSection)
        {
            Host = brokerSection.GetStringValue("host", "localhost");
            Port = brokerSection.GetIntValue("port", 8000);
            Realm = brokerSection.GetStringValue("realm", "com.checkout.store");
        }

        public string Host { get; }
        public int Port { get; }
        public string Realm { get; }
    }
}
