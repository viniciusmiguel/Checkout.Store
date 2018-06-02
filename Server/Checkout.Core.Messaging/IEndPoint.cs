using System;

namespace Checkout.Core.Messaging
{
    public interface IEndPoint<in T>
    {
        void PushMessage(T obj);
        void PushError(Exception ex);
    }
}
