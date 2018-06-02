using System.Collections.Generic;

namespace Checkout.Core.EventStore.Domain
{
    public interface IAggregate
    {
        int Version { get; }
        object Identifier { get; }
        void ApplyEvent(object @event);
        ICollection<object> GetPendingEvents();
        void ClearPendingEvents();
    }
}
