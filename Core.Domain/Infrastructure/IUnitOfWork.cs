using System;

namespace Core.NHibernate.Config
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        void Rollback();
    }
}