﻿//using DotnetCrawler.Data.Models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DotnetCrawler.Data.Repository
//{
//    //used this resources : https://codingblast.com/entity-framework-core-generic-repository/
//    public class GenericRepository<TEntity,TContext> : IGenericRepository<TEntity, TContext> where TEntity : class, IEntity where TContext : class
//    {
//        private readonly TContext _dbContext;

//        public GenericRepository()
//        {
//            //_dbContext = new MicrosofteShopOnWebCatalogDbContext();            
//        }

//        public IQueryable<TEntity> GetAll()
//        {
//            return _dbContext.Set<TEntity>().AsNoTracking();
//        }

//        public async Task<TEntity> GetById(int id)
//        {
//            return await _dbContext.Set<TEntity>()
//                        .AsNoTracking()
//                        .FirstOrDefaultAsync(e => e.Id == id);
//        }

//        public async Task CreateAsync(TEntity entity)
//        {
//            await _dbContext.Set<TEntity>().AddAsync(entity);
//            await _dbContext.SaveChangesAsync();
//        }

//        public async Task Update(int id, TEntity entity)
//        {
//            _dbContext.Set<TEntity>().Update(entity);
//            await _dbContext.SaveChangesAsync();
//        }

//        public async Task Delete(int id)
//        {
//            var entity = await GetById(id);
//            _dbContext.Set<TEntity>().Remove(entity);
//            await _dbContext.SaveChangesAsync();
//        }

//    }
//}
