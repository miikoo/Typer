using Flurl.Http;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Typer.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Typer.Tests
{
    public class BaseTest
    {
        public IFlurlClient FlurlClient { get; set; }
        public IServiceProvider Services { get; set; }

        protected readonly TyperContext _context;
        public BaseTest()
        {
            var builder2 = WebHost.CreateDefaultBuilder()
                .ConfigureAppConfiguration(ConfigureAppConfiguration)
                .UseStartup<TestStartup>();

            var builder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<TestStartup>();
                }).ConfigureServices(services =>
                {
                    Services = services.BuildServiceProvider();
                });
            var server = new TestServer(builder2);
            Services = server.Host.Services;
            var client = server.CreateClient();
            FlurlClient = new FlurlClient(client);
            _context = Services.GetService<TyperContext>();

        }

        private static void ConfigureAppConfiguration(IConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.AddEnvironmentVariables();
        }
    }
}
