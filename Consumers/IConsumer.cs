using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bondisoft.AzureFunctions.HayFigus.Producers;

namespace Bondisoft.AzureFunctions.HayFigus.Consumers
{
	public interface IConsumer
	{
		public Task SendPublications(IEnumerable<Link> publications);
	}
}

