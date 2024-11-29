using Elfie.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SwissMex.DataAccess.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(string? includeProperties = null);
        TEntity? Get(Expression<Func<TEntity, bool>> filter, string? includeProperties = null);
        void Add(TEntity entity);
        //void Update(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
