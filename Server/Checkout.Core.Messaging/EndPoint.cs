using System;
using System.Reactive.Subjects;
using Serilog;

namespace Checkout.Core.Messaging
{
    internal class EndPoint<T> : IEndPoint<T>
    {
        private readonly ISubject<T> _subject;

        public EndPoint(ISubject<T> subject)
        {
            _subject = subject;
        }

        public void PushMessage(T obj)
        {
            try
            {
                _subject.OnNext(obj);
            }
            catch (Exception e)
            {
                Log.Error("Could not send message {message}", e.Message);
            }
        }

        public void PushError(Exception ex)
        {
            _subject.OnError(ex);
        }
    }
}
