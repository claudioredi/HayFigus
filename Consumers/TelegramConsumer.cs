using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bondisoft.AzureFunctions.HayFigus.Model;
using Bondisoft.AzureFunctions.HayFigus.Producers;
using Microsoft.Extensions.Configuration;
using Telegram.Bot;

namespace Bondisoft.AzureFunctions.HayFigus.Consumers
{
    public class TelegramConsumer : IConsumer
    {
        private readonly IConfiguration _configuration;

        public TelegramConsumer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendPublications(IEnumerable<Link> publications)
        {
            var body = "Panini se puso la 10 y largó algunas promos de figus y/o albums. Apurate que no duran mucho! Estas son las publicaciones con stock\n\n";
            body += string.Join("\n", publications.Select(l => $"{l.Title}\n{l.Url}\n\n"));

            var botId = _configuration.GetValue<string>("TelegramBotId");
            var chatId = _configuration.GetValue<long>("TelegramChatId");

            var bot = new TelegramBotClient(botId);
            await bot.SendTextMessageAsync(new Telegram.Bot.Types.ChatId(chatId), body);
        }
    }
}

