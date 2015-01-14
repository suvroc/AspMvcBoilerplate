using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Business.Tasks.Dto
{
    public class TaskDtoLight
    {
        public virtual string Name { get; set; }
        public virtual TaskStatus Status { get; set; }
    }
}
