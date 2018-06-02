namespace Checkout.Core.Shared
{
    public interface IConnected<out T>
    {
        T Value { get; }
        bool IsConnected { get; }
    }
}
