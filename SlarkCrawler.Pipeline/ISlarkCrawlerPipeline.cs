using SlarkCrawler.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SlarkCrawler.Pipeline
{
    public interface ISlarkCrawlerPipeline<TEntity> where TEntity : class, IEntity
    {
        Task Run(IEnumerable<TEntity> entity);
    }
}
