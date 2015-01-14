using Ploeh.AutoFixture;
using Ploeh.AutoFixture.NUnit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.NHibernate.Tests.Infrastructure
{
    public class AutoMoqDataAttribute : Attribute
    {
        //readonly AutoDataAttribute _autoDataAttr;

        //public AutoMoqDataAttribute()
        //{
        //    this._autoDataAttr = new AutoDataAttribute(
        //        new Fixture().Customize(new AutoMoqCustomization()));
        //}

        //public IEnumerable<object[]> GetData(MethodInfo method)
        //{
        //    return this._autoDataAttr.GetData(method);
        //}
    }
}
