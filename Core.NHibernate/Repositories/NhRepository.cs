using Core.Domain.Infrastructure;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate.Linq;

namespace Core.NHibernate.Repositories
{
    public class NhRepository<TEntity>
        : IRepository<TEntity>, IKeyRepository<TEntity, int>
        where TEntity : IEntity<int>
    {
        private ISession _session;

        public NhRepository(ISession session)
        {
            this._session = session;
        }

        public IQueryable<TEntity> GetAll()
        {
            return this._session.Query<TEntity>();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return this._session.Query<TEntity>().Single(expression);
        }

        public IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> expression)
        {
            return this._session.Query<TEntity>().Where(expression);
        }

        public bool Add(TEntity entity)
        {
            this._session.Save(entity);
            return true;
        }

        public bool Add(IEnumerable<TEntity> items)
        {
            foreach (var item in items)
            {
                this._session.Save(item);
            }
            return true;
        }

        public bool Update(TEntity entity)
        {
            this._session.Update(entity);
            return true;
        }

        public bool Delete(TEntity entity)
        {
            this._session.Delete(entity);
            return true;
        }

        public bool Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                this.Delete(entity);
            }
            return true;
        }

        public TEntity GetById(int id)
        {
            return this._session.Get<TEntity>(id);
        }
    }
}