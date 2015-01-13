using Core.NHibernate.Config;
using NHibernate;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Web.Common;

namespace Core.NHibernate.Config
{
    public class NHibernateModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<IDatabaseConfigurer>().To<SQLServerDatabaseConfigurer>();
            Bind<INHibernateBuilder>().To<NHibernateBuilder>().InSingletonScope();
            Bind<ISessionFactory>().ToMethod(context => context.Kernel.Get<INHibernateBuilder>().CreateSessionFactory()).InSingletonScope();
            Bind<ISession>().ToMethod(context => context.Kernel.Get<ISessionFactory>().OpenSession()).InRequestScope();
        }
    }
}
