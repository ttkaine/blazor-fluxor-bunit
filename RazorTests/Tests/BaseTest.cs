using System.Threading.Tasks;
using Bunit;
using Bunit.TestDoubles;
using Fluxor;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using RazorTests.Helpers;
using SystemUnderTest.Blazor.Store;
using TestContext = Bunit.TestContext;

namespace RazorTests.Tests
{
    public abstract class BaseTest : TestContextWrapper
    {
        protected TestAuthorizationContext AuthContext { get; set; }

        [SetUp]
        public async Task Setup()
        {
            TestContext = new TestContext();
            IWebHost webHost = WebHostProvider.GetWebHost();
            
            TestContext.Services.AddFallbackServiceProvider(webHost.Services);
            TestContext.Services.AddOptions();

            AuthContext = TestContext.AddTestAuthorization();
            AuthContext.SetAuthorized("TEST USER");
            TestContext.JSInterop.Mode = JSRuntimeMode.Loose;


        }

        [TearDown]
        public void TearDown()
        {
            //  AppState = null;
            IActionSubscriber subscriber = TestContext.Services.GetService<IActionSubscriber>();
            subscriber.UnsubscribeFromAllActions(this);
            TestContext?.Dispose();
        }

        [Test]
        public void TestTheTestsRun()
        {
            Assert.IsTrue(true);
        }
    }
}