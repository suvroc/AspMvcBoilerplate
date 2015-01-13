using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Core.Domain.Models; 

namespace Core.NHibernate.Mappings {
    
    
    public class CategoryMap : ClassMap<Category> {
        
        public CategoryMap() {
			Table("Categories");
			LazyLoad();
			Id(x => x.Id).GeneratedBy.Identity().Column("CategoryId");
			Map(x => x.Name).Column("Name").Not.Nullable();
			HasMany(x => x.Tasks).KeyColumn("CategoryId");
        }
    }
}
