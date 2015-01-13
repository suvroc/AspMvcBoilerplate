using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;

namespace Core.NHibernate.Config
{
    public interface IDatabaseConfigurer
    {
        IPersistenceConfigurer Configurer();
        void BuildSchema(Configuration configuration);
    }
}
