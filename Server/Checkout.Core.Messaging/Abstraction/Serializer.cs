using System;

namespace Checkout.Core.Messaging.Abstraction
{
    public class Serializer : ISerializer
    {
        public byte[] Serialize<T>(T instance)
        {
            throw new NotImplementedException();
        }

        public T Deserialize<T>(byte[] payload)
        {
            throw new NotImplementedException();
        }
    }
}
