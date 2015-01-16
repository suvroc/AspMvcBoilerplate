

using Core.Domain.Types;
namespace Application.Business.Tasks.Dto
{
    public class TaskDto
    {
        public string CategoryName { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TaskStatus Status { get; set; }
    }
}