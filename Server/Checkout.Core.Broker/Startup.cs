using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WampSharp.AspNetCore.WebSockets.Server;
using WampSharp.Binding;
using WampSharp.V2;

namespace Checkout.Core.Broker
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
          loggerFactory.AddConsole();

          if (env.IsDevelopment())
          {
            app.UseDeveloperExceptionPage();
          }

          WampHost host = new WampHost();

          app.Map("/ws", builder =>
          {
            builder.UseWebSockets(new WebSocketOptions());

            host.RegisterTransport(new AspNetCoreWebSocketTransport(builder),
              new JTokenJsonBinding(),
              new JTokenMsgpackBinding());
          });
          host.Open();
        }
    }
}
