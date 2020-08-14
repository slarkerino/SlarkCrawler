using SlarkCrawler.Data.Repository;
using SlarkCrawler.Downloader;
using SlarkCrawler.Pipeline;
using SlarkCrawler.Processor;
using SlarkCrawler.Request;
using SlarkCrawler.Scheduler;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SlarkCrawler.Core
{
    public class SlarkCrawler<TEntity> : ISlarkCrawler where TEntity : class, IEntity
    {
        public ISlarkCrawlerRequest Request { get; private set; }
        public ISlarkCrawlerDownloader Downloader { get; private set; }
        public ISlarkCrawlerProcessor<TEntity> Processor { get; private set; }
        public ISlarkCrawlerScheduler Scheduler { get; private set; }
        public ISlarkCrawlerPipeline<TEntity> Pipeline { get; private set; }

        public SlarkCrawler()
        {

        }

        public SlarkCrawler<TEntity> AddRequest(ISlarkCrawlerRequest request)
        {
            Request = request;
            return this;
        }

        public SlarkCrawler<TEntity> AddDownloader(ISlarkCrawlerDownloader downloader)
        {
            Downloader = downloader;
            return this;
        }

        public SlarkCrawler<TEntity> AddProcessor(ISlarkCrawlerProcessor<TEntity> processor)
        {
            Processor = processor;
            return this;
        }

        public SlarkCrawler<TEntity> AddScheduler(ISlarkCrawlerScheduler scheduler)
        {
            Scheduler = scheduler;
            return this;
        }

        public SlarkCrawler<TEntity> AddPipeline(ISlarkCrawlerPipeline<TEntity> pipeline)
        {
            Pipeline = pipeline;
            return this;
        }

        public async Task Crawle()
        {
            var linkReader = new SlarkCrawlerPageLinkReader(Request);
            var links = await linkReader.GetLinks(Request.Url, 0);
            links = new List<string> { "https://tieba.baidu.com/p/6853392656" };
            foreach (var url in links)
            {
                var document = await Downloader.Download(url);
                var entity = await Processor.Process(document);
                await Pipeline.Run(entity);
            }
        }
    }
}
