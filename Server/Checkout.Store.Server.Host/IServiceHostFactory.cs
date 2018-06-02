using System;
using Checkout.Core.Messaging;
using Checkout.Core.Shared;
using EventStore.ClientAPI;

namespace Checkout.Core.Server.Host
{
    public interface IServiceHostFactory : IDisposable
    {
        IDisposable Initialize(IObservable<IConnected<IBroker>> broker);
    }

    public interface IServiceHostFactoryWithEventStore : IServiceHostFactory
    {
        IDisposable Initialize(IObservable<IConnected<IBroker>> broker,
                               IObservable<IConnected<IEventStoreConnection>> eventStore);
    }
}
