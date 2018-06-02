using System;

namespace Checkout.Core.Messaging.Abstraction
{
    public interface IRequestStreamServer<out TRequest, in TUpdate>
    {
        IDisposable Stream(RequestStreamHandler<TRequest, TUpdate> requestStreamHandler);
    }
}
