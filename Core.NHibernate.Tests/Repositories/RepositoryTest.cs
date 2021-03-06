﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using Core.Domain.Models;
using Ploeh.AutoFixture;
using FluentNHibernate.Testing;
using Ploeh.AutoFixture.NUnit2;

namespace Core.NHibernate.Tests.Repositories
{
    [TestFixture]
    public class RepositoryTest : BaseNHibernateTest
    {
        [SetUp]
        public void Initialize()
        {
            Configure();
        }

        [Test]
        public void CheckDatabaseMapping()
        {
            Fixture fixture = new Fixture();
            //fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            fixture.Inject(Enumerable.Empty<Task>());

            var obj = fixture.Create<Category>();

            _session.Save(obj);

            var result = _session.Query<Category>()
                .SingleOrDefault(x => x.Id == obj.Id);

            Assert.NotNull(result);
        }

        [Test]
        public void CheckAllMappings()
        {
            var fixture = new Fixture();
            fixture.Inject(Enumerable.Empty<Task>());
            new PersistenceSpecification<Category>(_session)
            .VerifyTheMappings(fixture.Create<Category>());
        }
    }
}
