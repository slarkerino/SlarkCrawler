using System;
using System.Collections.Generic;
using System.Text;

namespace SlarkCrawler.Request
{
    public class SlarkCrawlerRequest : ISlarkCrawlerRequest
    {
        public string Url { get; set; }
        public string Regex { get; set; }
        public long TimeOut { get; set; }        
    }
}
