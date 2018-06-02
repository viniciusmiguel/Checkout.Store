using System;
using Checkout.Core.Shared.Config;

namespace Checkout.Core.Messaging
{
    public static class BrokerUri
    {
        public static string FromConfig(IBrokerConfiguration config)
        {
            var builder = new UriBuilder
            {
                Scheme = "ws",
                Path = "ws",
                Host = config.Host,
                Port = config.Port
            };

            return builder.ToString();
        }
    }
}
