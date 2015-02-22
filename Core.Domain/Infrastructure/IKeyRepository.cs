namespace Core.Domain.Infrastructure
{
    /// <summary>
    /// Keyed repository interface
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type</typeparam>
    public interface IKeyRepository<TEntity, TPrimaryKey>
    {
        /// <summary>
        /// Get record b id
        /// </summary>
        /// <param name="id">Record id</param>
        /// <returns>Record</returns>
        TEntity GetById(TPrimaryKey id);
    }
}