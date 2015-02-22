using Core.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Filters
{
    public class UnitOfWorkFilter : IActionFilter
    {
        private readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkFilter(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (_unitOfWork.IsActive)
            {
                if (filterContext.Exception == null)
                {
                    _unitOfWork.Commit();
                }
                else
                {
                    _unitOfWork.Rollback();
                }
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _unitOfWork.Begin();
        }
    }
}