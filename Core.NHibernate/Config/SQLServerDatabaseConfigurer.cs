using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
