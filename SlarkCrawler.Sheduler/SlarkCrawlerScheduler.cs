﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SlarkCrawler.Scheduler
{
    public class SlarkCrawlerScheduler : ISlarkCrawlerScheduler
    {
        public long RetryTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task Schedule()
        {
            // TODO : Implement Quartz or Hangfire
            throw new NotImplementedException();
        }
    }
}
