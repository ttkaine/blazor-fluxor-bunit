using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using SystemUnderTest.Blazor;

namespace RazorTests.Helpers
{
    public static class WebHostProvider
    {
        public static IWebHost GetWebHost()
        {
            Startup startup = null;
            var webHost = WebHost
                .CreateDefaultBuilder()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.Sources.Clear();
                    config.AddConfiguration(hostingContext.Configuration);
                    config.AddJsonFile("appsettings.json");
                    startup =new  Startup(config.Build());
                })
                .ConfigureServices(sc =>
                {
                    startup.ConfigureServices(sc);
                })
                .UseStartup<EmptyStartup>()
                .Build();

            return webHost;
        }
    }
}