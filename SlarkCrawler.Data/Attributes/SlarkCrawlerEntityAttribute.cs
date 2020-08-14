using System;
using System.Collections.Generic;
using System.Text;

namespace SlarkCrawler.Data.Attributes
{
    public class SlarkCrawlerEntityAttribute : Attribute
    {
        public string XPath { get; set; }
    }    
}
