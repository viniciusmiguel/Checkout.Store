using EventStore.ClientAPI;

namespace Checkout.Core.EventStore
{
    public interface IEventStore
    {
        IEventStoreConnection Connection { get; }
    }
}
