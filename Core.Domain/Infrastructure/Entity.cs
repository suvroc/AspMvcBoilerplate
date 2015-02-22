namespace Core.Domain.Infrastructure
{
    /// <summary>
    /// Database entity
    /// </summary>
    public class Entity : IEntity<int>
    {
        /// <summary>
        /// Id
        /// </summary>
        public virtual int Id { get; set; }
    }
}