using Core.Domain.Infrastructure;
using NHibernate;
using System;
using System.Data;

namespace Core.NHibernate.Config
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISession Session;
        private ITransaction transaction;

        public UnitOfWork(ISession session)
        {
            this.Session = session;
            this.Session.FlushMode = FlushMode.Auto;
            //this.transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void Dispose()
        {
            this.Session.Close();
        }

        public void Commit()
        {
            if (!this.transaction.IsActive)
            {
                throw new InvalidOperationException("No active transation");
            }
            this.Session.Flush();
            this.transaction.Commit();
        }

        public void Rollback()
        {
            if (this.transaction.IsActive)
            {
                this.transaction.Rollback();
            }
        }

        public void Begin()
        {
            this.transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);
        }


        public bool IsActive
        {
            get
            {
                return this.transaction.IsActive;
            }
        }
    }
}