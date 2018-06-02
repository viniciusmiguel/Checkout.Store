using System;
using Checkout.Core.EventStore.Connection;
using EventStore.ClientAPI;

namespace Checkout.Core.EventStore
{
    public class ExternalEventStore : IEventStore
    {
        public ExternalEventStore(Uri uri)
        {
            Connection = EventStoreConnection.Create(EventStoreConnectionSettings.Default, uri).Result;
        }

        public IEventStoreConnection Connection { get; }
    }
}
