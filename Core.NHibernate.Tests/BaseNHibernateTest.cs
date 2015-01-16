using Core.NHibernate.Config;
using FluentNHibernate.Cfg;
using NHibernate;

namespace Core.NHibernate.Tests
{
    public class BaseNHibernateTest
    {
        protected ISession _session;

        protected ISessionFactory _sessionFactory;

        protected ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
              .Database(FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2012.ConnectionString(System.Configuration.ConfigurationManager.
                ConnectionStrings["ConnectionString"].ConnectionString))

              //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<HotelMap>())
                //.ExposeConfiguration(BuildSchema)
              .BuildSessionFactory();
        }

        protected void Configure()
        {
            var nHibernateBuilder = new NHibernateBuilder(
                new SQLServerDatabaseConfigurer());
            _sessionFactory = nHibernateBuilder.CreateSessionFactory();
            _session = _sessionFactory.OpenSession();
        }
    }
}