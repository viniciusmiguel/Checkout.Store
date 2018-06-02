using System;

namespace Checkout.Core.Messaging.Abstraction
{
    public interface IStreamHandler<in TUpdate>
    {
        void OnUpdated(TUpdate update);
        void OnCompleted();
        void OnError(Exception error);
    }
}
