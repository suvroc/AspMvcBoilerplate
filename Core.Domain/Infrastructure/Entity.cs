namespace Core.Domain.Infrastructure
{
    public class Entity : IEntity<int>
    {
        public virtual int Id { get; set; }
    }
}