using System;
using System.Collections.Generic;
using System.Linq;
using Bondisoft.AzureFunctions.HayFigus.Model;
using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using Microsoft.Extensions.Configuration;

namespace Bondisoft.AzureFunctions.HayFigus.Producers
{
	public class PaniniWebScrapperProducer : IProducer
    {
        private readonly IConfiguration _configuration;

        public PaniniWebScrapperProducer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Link> GetPublications()
        {
            var url = _configuration.GetValue<string>("ScrapperUrl");;
            var web = new HtmlWeb();
            var doc = web.Load(url);

            var nodes = doc.QuerySelectorAll(".js-item-product img:not(.opacity-50)")
                           .Select(i => i.ParentNode.ParentNode);

            return nodes.Select(n => new Link
            {
                Url = n.Attributes["href"].Value,
                Title = n.Attributes["title"].Value
            });
        }
    }
}

