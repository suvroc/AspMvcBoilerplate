namespace Core.Domain.Infrastructure
{
    public interface IKeyRepository<TEntity, TPrimaryKey>
    {
        TEntity GetById(TPrimaryKey id);
    }
}