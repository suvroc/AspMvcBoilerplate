using NHibernate;

namespace Core.NHibernate.Config
{
    public interface INHibernateBuilder
    {
        ISessionFactory CreateSessionFactory();
    }
}