using SlarkCrawler.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace SlarkCrawler.Pipeline
{
    public class SlarkCrawlerPipeline<TEntity> : ISlarkCrawlerPipeline<TEntity> where TEntity : class, IEntity
    {
        //private readonly IGenericRepository<TEntity> _repository;

        public SlarkCrawlerPipeline()
        {
            //_repository = new GenericRepository<TEntity>();
        }

        public async Task Run(IEnumerable<TEntity> entityList)
        {
            foreach (var entity in entityList)
            {
                Console.WriteLine(JsonSerializer.Serialize(entity));
               //await _repository.CreateAsync(entity);
            }
        }
    }
}
