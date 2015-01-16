using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;

namespace Core.NHibernate.Config
{
    public class SQLServerDatabaseConfigurer : IDatabaseConfigurer
    {
        public IPersistenceConfigurer Configurer()
        {
            string connString = System.Configuration.ConfigurationManager.
                ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            return MsSqlConfiguration.MsSql2012.ConnectionString(connString);
        }

        public void BuildSchema(Configuration configuration)
        {
        }
    }
}