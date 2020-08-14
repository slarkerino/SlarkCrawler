using System;
using System.Collections.Generic;
using System.Text;

namespace SlarkCrawler.Request
{
    public interface ISlarkCrawlerRequest
    {
        string Url { get; set; }
        string Regex { get; set; }
        long TimeOut { get; set; }
    }
}
