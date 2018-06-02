namespace Checkout.Core.Shared.Config
{
    public interface IBrokerConfiguration
    {
        string Host { get; }
        int Port { get; }
        string Realm { get; }
    }
}
