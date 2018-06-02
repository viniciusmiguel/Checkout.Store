namespace Checkout.Core.Shared.Config
{
    public interface IServiceConfiguration
    {
        IEventStoreConfiguration EventStore { get; }
        IBrokerConfiguration Broker { get; }
    }
}
