using System.Net;
using Checkout.Core.Shared.Config;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Checkout.Core.Broker
{
    public class Program
    {
        private static IServiceConfiguration _serviceConfiguration;
        public static void Main(string[] args)
        {
          _serviceConfiguration = ServiceConfiguration.FromArgs(args);
          BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
          return WebHost.CreateDefaultBuilder(args)
            .UseKestrel(options =>
            {
              var host = _serviceConfiguration.Broker.Host.Equals("localhost")
                ? "127.0.0.1"
                : _serviceConfiguration.Broker.Host;
              options.Listen(IPAddress.Parse(host), _serviceConfiguration.Broker.Port);
            })
            .UseStartup<Startup>()
            .Build();
        }
    }
}
