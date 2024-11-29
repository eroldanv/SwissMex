using Microsoft.EntityFrameworkCore;
using SwissMex.DataAccess.Data;
using SwissMex.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace SwissMex.DataAccess.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext appCtx;
        internal DbSet<TEntity> dbSet;

        public Repository(ApplicationDbContext appCtx)
        {
            this.appCtx = appCtx; 
            this.dbSet = this.appCtx.Set<TEntity>();
            
        }
        public void Add(TEntity entity)
        {
            dbSet.Add(entity);            
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> filter, string? includeProperties = null)
        {
            
            IQueryable<TEntity> query = dbSet;

            if(!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var property in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }

            query = query.Where(filter);

            return query.FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll(string? includeProperties = null)
        {
            IQueryable<TEntity> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var property in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }
            return query.ToList();
        }

        public void Remove(TEntity entity)
        {
           dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
           dbSet.RemoveRange(entities);
        }
    }
}
