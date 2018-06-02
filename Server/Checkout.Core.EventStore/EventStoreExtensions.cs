using System;
using System.Reactive.Linq;
using System.Text;
using Checkout.Core.EventStore.Connection;
using Checkout.Core.Shared;
using EventStore.ClientAPI;
using Newtonsoft.Json;

namespace Checkout.Core.EventStore
{
    public static class EventStoreExtensions
    {
        public static T GetEvent<T>(this RecordedEvent evt)
        {
            {
                var eventString = Encoding.UTF8.GetString(evt.Data);
                return JsonConvert.DeserializeObject<T>(eventString);
            }
        }

        public static IObservable<IConnected<IEventStoreConnection>> GetEventStoreConnectedStream(this ConnectionStatusMonitor monitor,
                                                                                                  IEventStoreConnection connection)
        {
            return monitor.ConnectionInfoChanged.Where(x => x.Status == ConnectionStatus.Connected ||
                                                            x.Status == ConnectionStatus.Disconnected)
                          .Select(c => c.Status == ConnectionStatus.Connected
                              ? Connected.Yes(connection)
                              : Connected.No<IEventStoreConnection>());
        }
    }
}
