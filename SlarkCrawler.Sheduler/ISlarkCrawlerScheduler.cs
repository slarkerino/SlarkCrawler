using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SlarkCrawler.Scheduler
{
    public interface ISlarkCrawlerScheduler
    {
        long RetryTime { get; set; }
        Task Schedule();
    }
}
