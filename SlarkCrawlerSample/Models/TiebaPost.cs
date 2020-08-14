using SlarkCrawler.Data.Attributes;
using SlarkCrawler.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlarkCrawlerSample.Models
{
    [SlarkCrawlerEntity(XPath = "//div[contains(@class, 'l_post')]")]
    public class TiebaPost : IEntity
    {
        public int Id { get; set; }
        [SlarkCrawlerField(Expression = "1", SelectorType = SelectorType.FixedValue)]
        public int CatalogBrandId { get; set; }
        [SlarkCrawlerField(Expression = "1", SelectorType = SelectorType.FixedValue)]
        public int CatalogTypeId { get; set; }
        public string Description { get; set; }
        [SlarkCrawlerField(Expression = "//cc//div[contains(@class, 'j_d_post_content')]", SelectorType = SelectorType.XPath)]
        public string Name { get; set; }
        public string PictureUri { get; set; }
        public decimal Price { get; set; }
    }
}
