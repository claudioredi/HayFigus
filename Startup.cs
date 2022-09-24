using System;
using Bondisoft.AzureFunctions.HayFigus.Consumers;
using Bondisoft.AzureFunctions.HayFigus.Producers;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Bondisoft.AzureFunctions.HayFigus.Startup))]
namespace Bondisoft.AzureFunctions.HayFigus
{
	public class Startup : FunctionsStartup
	{
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddTransient<IProducer, PaniniWebScrapperProducer>();
            builder.Services.AddTransient<IConsumer, TelegramConsumer>();            
        }
    }
}

