using System;
using Checkout.Core.Messaging.Abstraction;

namespace Checkout.Core.Messaging.WAMP
{
    internal class MessageFactory : IMessageFactory
    {
        public IMessage Create(byte[] payload, TimeSpan timeToLive)
        {
            throw new NotImplementedException();
        }

        public IMessage Create(TimeSpan timeToLive)
        {
            throw new NotImplementedException();
        }
    }
}
