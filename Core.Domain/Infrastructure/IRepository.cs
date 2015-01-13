using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Infrastructure
{
    public interface IRepository<TEntity> : IKeyRepository<TEntity, int>
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> expression);
        bool Add(TEntity entity);
        bool Add(IEnumerable<TEntity> items);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool Delete(IEnumerable<TEntity> entities);
    }
}
