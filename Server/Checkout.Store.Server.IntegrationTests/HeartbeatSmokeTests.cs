using System;
using System.Reactive.Linq;
using Checkout.Core.Shared;
using Xunit;

namespace Checkout.Store.Server.IntegrationTests
{
    /// <summary>
    /// Tests to Check if the services are operational
    /// You must have the broker and the individual services running to test!
    /// </summary>
    public class HeartbeatSmokeTests
    {
        [Theory]
        [InlineData(ServiceTypes.Product)]
        [InlineData(ServiceTypes.Basket)]
        [InlineData(ServiceTypes.Order)]
        public async void ShouldReceiveHeartbeatForServices(string serviceType)
        {
            var channel = await new TestBroker().OpenChannel();

            var heartbeat = await channel.RealmProxy.Services.GetSubject<dynamic>("status")
                                         .Where(hb => hb.Type == serviceType)
                                         .Timeout(TimeSpan.FromSeconds(2))
                                         .Take(1);

            Assert.NotNull(heartbeat.Instance);
        }
    }
}
