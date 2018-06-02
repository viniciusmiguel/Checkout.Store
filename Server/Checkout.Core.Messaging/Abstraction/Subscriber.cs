using System;

namespace Checkout.Core.Messaging.Abstraction
{
    public class Subscriber : ISubscriber
    {
        public IDisposable Subscribe(MessageHandler messageHandler)
        {
            throw new NotImplementedException();
        }

        public IDisposable Subscribe(ISelectionExpression selectionExpression, MessageHandler messageHandler)
        {
            throw new NotImplementedException();
        }
    }
}
