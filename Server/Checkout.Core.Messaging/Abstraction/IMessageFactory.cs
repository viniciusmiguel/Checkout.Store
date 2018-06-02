using System;

namespace Checkout.Core.Messaging.Abstraction
{
    public interface IMessageFactory
    {
        IMessage Create(byte[] payload, TimeSpan timeToLive);
        IMessage Create(TimeSpan timeToLive);
    }
}
