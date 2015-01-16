using Core.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper.QueryableExtensions;
using Application.Business.Tasks.Dto;
using AutoMapper;
using Core.Domain.Models;
using Core.Domain.Types;

namespace Application.Business.Tasks
{
    public class TaskService : ITaskService
    {
        private IRepository<Task> _taskRepository;

        public TaskService(IRepository<Task> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Dto.TaskDto GetTask(int id)
        {
            return Mapper.Map<TaskDto>(_taskRepository.GetById(id));
        }

        public List<Dto.TaskDtoLight> GetAll()
        {
            return _taskRepository.GetAll()
                .Project().To<TaskDtoLight>()
                .ToList();
        }

        public void MarkTaskAsFinished(int id)
        {
            var task = _taskRepository.GetById(id);
            if (task.Status != TaskStatus.NotFinished)
            {
                throw new InvalidOperationException();
            }
            task.Status = TaskStatus.Finished;
            _taskRepository.Update(task);
        }


        public IQueryable<TaskDtoLight> GetAllQuery()
        {
            return _taskRepository.GetAll()
                .Project().To<TaskDtoLight>();
        }
    }
}
