using System;
using System.Collections.Generic;
using System.Text;

namespace SlarkCrawler.Data.Attributes
{
    public class SlarkCrawlerFieldAttribute : Attribute
    {
        public string Expression { get; set; }
        public SelectorType SelectorType { get; set; }
    }
}
