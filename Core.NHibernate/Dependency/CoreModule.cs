using Core.Domain.Infrastructure;
using Core.NHibernate.Config;
using Core.NHibernate.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.NHibernate.Dependency
{
    public class CoreModule : NinjectModule
    {

        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();

            // Repositories
            Bind(typeof(IRepository<>)).To(typeof(NhRepository<>));
        }
    }
}
