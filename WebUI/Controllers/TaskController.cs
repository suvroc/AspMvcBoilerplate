using Application.Business.Tasks;
using Application.Business.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Filters;

namespace WebUI.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;

        public TaskController (ITaskService taskService)
	    {
            _taskService = taskService;
	    }

        [HttpGet]
        public JsonResult GetTask(int taskId)
        {
            return Json(_taskService.GetTask(taskId), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(_taskService.GetAll(), 
                JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [UnitOfWork]
        public JsonResult MarkTaskAsFinished(int taskId)
        {
            _taskService.MarkTaskAsFinished(taskId);
            return Json(true);
        }

        [HttpPut]
        public JsonResult AddTask(TaskDto task)
        {
            return Json(_taskService.AddTask(task));
        }
    }
}