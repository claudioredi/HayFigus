using System.Linq;
using System.Threading.Tasks;
using Bondisoft.AzureFunctions.HayFigus.Consumers;
using Bondisoft.AzureFunctions.HayFigus.Producers;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Bondisoft.AzureFunctions.HayFigus
{
    public class HayFigus
    {
        private readonly IProducer _producer;
        private readonly IConsumer _consumer;

        public HayFigus(IProducer producer, IConsumer consumer)
        {
            _producer = producer;
            _consumer = consumer;
        }

        [FunctionName("HayFigus")]
        public async Task Run([TimerTrigger("0/30 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            try
            {
                var publications = _producer.GetPublications().Where(l => l.Title != "1 álbum FIFA WORLD CUP QATAR 2022");

                if (publications.Any())
                {
                    await _consumer.SendPublications(publications);
                }
            }
            catch (System.Exception ex)
            {
                log.LogError(ex, ex.Message);
            }
        }
    }
}