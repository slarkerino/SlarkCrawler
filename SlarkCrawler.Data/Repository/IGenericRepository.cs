using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlarkCrawler.Data.Repository
{
    public interface IGenericRepository<TEntity, TContext> where TEntity : class where TContext:class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task CreateAsync(TEntity entity);
        Task Update(int id, TEntity entity);
        Task Delete(int id);
    }
}
