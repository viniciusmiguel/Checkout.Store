using System;
using Checkout.Core.Shared.Config;
using EventStore.ClientAPI;

namespace Checkout.Core.EventStore.Connection
{
    public class EventStoreConnectionFactory
    {
        public static IEventStoreConnection Create(EventStoreLocation eventStoreLocation, IEventStoreConfiguration configuration)
        {
            IEventStore eventStore;

            if (eventStoreLocation == EventStoreLocation.Embedded)
            {
                //eventStore = new EmbeddedEventStore();
                throw new NotSupportedException();
            }
            else
            {
                eventStore = new ExternalEventStore(EventStoreUri.FromConfig(configuration));
            }

            return eventStore.Connection;
        }
    }
}
