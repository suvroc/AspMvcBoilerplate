using Application.Business.Mappings;
using Application.Business.Tasks;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Business.Dependency
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITaskService>().To<TaskService>();

            DtoMappings.Map();
        }
    }
}
