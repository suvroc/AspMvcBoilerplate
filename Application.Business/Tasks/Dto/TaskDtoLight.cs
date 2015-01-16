

using Core.Domain.Types;
namespace Application.Business.Tasks.Dto
{
    public class TaskDtoLight
    {
        public int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual TaskStatus Status { get; set; }
    }
}