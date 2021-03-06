using System;
using System.Threading.Tasks;
using WampSharp.V2;
using WampSharp.V2.Client;
using WampSharp.V2.Fluent;

namespace Checkout.Store.Server.IntegrationTests
{
    public class TestBroker
    {
        private readonly IWampChannel _channel;

        public TestBroker()
        {
            _channel = new WampChannelFactory()
                .ConnectToRealm("com.checkout.store")
                .WebSocketTransport(new Uri(TestAddress.Broker))
                .JsonSerialization()
                .Build();
        }

        public async Task<IWampChannel> OpenChannel()
        {
            await _channel.Open();
            return _channel;
        }
    }
}
