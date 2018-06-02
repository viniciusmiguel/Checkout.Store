using System;

namespace Checkout.Core.Messaging.Abstraction
{
    public delegate IDisposable RequestStreamHandler<in TRequest, out TUpdate>(
        IRequestContext context,
        TRequest request,
        IStreamHandler<TUpdate> streamHandler);
}
