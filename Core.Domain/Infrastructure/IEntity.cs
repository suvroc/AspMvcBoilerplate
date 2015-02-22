namespace Core.Domain.Infrastructure
{
    /// <summary>
    /// Database entity interface
    /// </summary>
    /// <typeparam name="TPrimaryKey">Key type</typeparam>
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Id
        /// </summary>
        TPrimaryKey Id { get; set; }
    }
}