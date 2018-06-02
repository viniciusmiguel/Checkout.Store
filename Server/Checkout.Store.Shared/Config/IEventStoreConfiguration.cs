namespace Checkout.Core.Shared.Config
{
    public interface IEventStoreConfiguration
    {
        string Host { get; }
        int Port { get; }
    }
}
