namespace Checkout.Core.Messaging.Abstraction
{
    public interface IMessage
    {
        IMessageProperties Properties { get; }
        byte[] Payload { get; }
        string SessionId { get; }
        ITransientDestination ReplyTo { get; }
    }
}
