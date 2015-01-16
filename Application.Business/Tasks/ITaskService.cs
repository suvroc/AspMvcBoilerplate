using Application.Business.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Business.Tasks
{
    public interface ITaskService
    {
        TaskDto GetTask(int id);

        List<TaskDtoLight> GetAll();

        IQueryable<TaskDtoLight> GetAllQuery();

        void MarkTaskAsFinished(int id);
    }
}
