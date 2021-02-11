using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Net.Http;

namespace FizzAPI.Test.Integration
{
    public class TestClientProvider
    {
        public HttpClient Client { get; private set; }

        public TestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .ConfigureTestServices(services =>
                {
                    services.AddAuthentication(options =>
                    {
                        options.DefaultAuthenticateScheme = TestAuthHandler.DefaultScheme;
                        options.DefaultScheme = TestAuthHandler.DefaultScheme;
                    }).AddScheme<AuthenticationSchemeOptions, TestAuthHandler>(
                           TestAuthHandler.DefaultScheme, options => { });
                }));

            Client = server.CreateClient();
            Client.BaseAddress = new Uri("https://localhost:44356/");
        }
    }
}
