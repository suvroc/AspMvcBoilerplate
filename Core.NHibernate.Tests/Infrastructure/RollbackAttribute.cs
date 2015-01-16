using NUnit.Framework;
using System;

namespace Core.NHibernate.Tests.Infrastructure
{
    public class RollbackAttribute : Attribute, ITestAction
    {
        //private TransactionScope transaction;

        public void BeforeTest(TestDetails testDetails)
        {
            //transaction = new TransactionScope();
        }

        public void AfterTest(TestDetails testDetails)
        {
            //transaction.Dispose();
        }

        public ActionTargets Targets
        {
            get { return ActionTargets.Test; }
        }
    }
}