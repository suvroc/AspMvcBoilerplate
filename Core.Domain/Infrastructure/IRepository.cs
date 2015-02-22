using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.Domain.Infrastructure
{
    /// <summary>
    /// Repository interface
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public interface IRepository<TEntity> : IKeyRepository<TEntity, int>
    {
        /// <summary>
        /// Get all records
        /// </summary>
        /// <returns>All records query</returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Get single record
        /// </summary>
        /// <param name="expression">Expression to select record</param>
        /// <returns>Record</returns>
        TEntity Get(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// Get records list
        /// </summary>
        /// <param name="expression">Expression to filter records</param>
        /// <returns>Records list</returns>
        IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// Add record
        /// </summary>
        /// <param name="entity">Record</param>
        /// <returns>Result</returns>
        bool Add(TEntity entity);

        /// <summary>
        /// Add records
        /// </summary>
        /// <param name="items">Records list</param>
        /// <returns>Result</returns>
        bool Add(IEnumerable<TEntity> items);

        /// <summary>
        /// Update record
        /// </summary>
        /// <param name="entity">Record</param>
        /// <returns>Result</returns>
        bool Update(TEntity entity);

        /// <summary>
        /// Delete record
        /// </summary>
        /// <param name="entity">Record</param>
        /// <returns>Result</returns>
        bool Delete(TEntity entity);

        /// <summary>
        /// Delete records
        /// </summary>
        /// <param name="entities">Records list</param>
        /// <returns>Result</returns>
        bool Delete(IEnumerable<TEntity> entities);
    }
}