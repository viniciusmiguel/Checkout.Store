using System;
using System.Reactive;

namespace Checkout.Core.Messaging
{
    public interface IPrivateEndPoint<in T> : IEndPoint<T>
    {
        IObservable<Unit> TerminationSignal { get; }
    }
}
