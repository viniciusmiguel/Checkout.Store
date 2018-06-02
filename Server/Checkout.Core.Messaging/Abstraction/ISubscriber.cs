using System;

namespace Checkout.Core.Messaging.Abstraction
{
    public interface ISubscriber
    {
        IDisposable Subscribe(MessageHandler messageHandler);
        IDisposable Subscribe(ISelectionExpression selectionExpression, MessageHandler messageHandler);
    }
}
