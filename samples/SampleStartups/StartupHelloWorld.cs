using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

// Note that this sample will not run. It is only here to illustrate usage patterns.

namespace SampleStartups
{
    public class StartupHelloWorld : StartupBase
    {
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public override void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }


        public override void ConfigureServices(IServiceCollection services)
        {

        }

        // Entry point for the application.
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                //.UseKestrel()
                .UseFakeServer()
                .UseStartup<StartupHelloWorld>()
                .Build();

            host.Run();
        }
    }
}
