using System.Collections.Generic;
using System.Threading.Tasks;

namespace Checkout.Core.EventStore.Domain
{
    public interface IRepository
    {
        Task<TAggregate> GetById<TAggregate>(object id) where TAggregate : IAggregate, new();
        Task<int> SaveAsync(AggregateBase aggregate, params KeyValuePair<string, string>[] extraHeaders);
    }
}
