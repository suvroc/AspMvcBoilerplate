using System;

namespace Core.Domain.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        void Begin();
        void Commit();
        void Rollback();
        bool IsActive { get; }
    }
}