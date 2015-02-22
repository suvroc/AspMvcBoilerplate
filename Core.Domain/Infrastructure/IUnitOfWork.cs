using System;

namespace Core.Domain.Infrastructure
{
    /// <summary>
    /// Unit of work interface
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Begin transaction
        /// </summary>
        void Begin();

        /// <summary>
        /// Commit transaction
        /// </summary>
        void Commit();

        /// <summary>
        /// Rollback transaction
        /// </summary>
        void Rollback();

        /// <summary>
        /// Current transaction is active
        /// </summary>
        bool IsActive { get; }
    }
}