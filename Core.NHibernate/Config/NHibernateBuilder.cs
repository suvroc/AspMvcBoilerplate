using Core.NHibernate.Mappings;
using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.NHibernate.Config
{
    public class NHibernateBuilder : INHibernateBuilder
    {
        private readonly IDatabaseConfigurer _databaseConfigurer;

        public NHibernateBuilder(IDatabaseConfigurer databaseConfigurer)
        {
            _databaseConfigurer = databaseConfigurer;
        }

        public ISessionFactory CreateSessionFactory()
        {
            return Fluently
                .Configure()
                .Database(_databaseConfigurer.Configurer)
                .Mappings(m => m.FluentMappings
                    .Add<TaskMap>()
                    .Add<CategoryMap>())
                .BuildSessionFactory();
        }
    }
}
