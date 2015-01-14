﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
