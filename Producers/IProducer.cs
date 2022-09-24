using System;
using System.Collections.Generic;

namespace Bondisoft.AzureFunctions.HayFigus.Producers
{
	public interface IProducer
	{
		IEnumerable<Link> GetPublications();
	}
}

