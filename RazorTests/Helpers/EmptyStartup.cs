using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RazorTests.Helpers
{
    public class EmptyStartup
    {
        public EmptyStartup(IConfiguration _) { }

        public void ConfigureServices(IServiceCollection _) { }

        public void Configure(IApplicationBuilder _) { }
    }
}