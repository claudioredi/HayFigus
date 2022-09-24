using System;
using System.Collections.Generic;
using Bondisoft.AzureFunctions.HayFigus.Model;

namespace Bondisoft.AzureFunctions.HayFigus.Producers
{
	public interface IProducer
	{
		IEnumerable<Link> GetPublications();
	}
}

