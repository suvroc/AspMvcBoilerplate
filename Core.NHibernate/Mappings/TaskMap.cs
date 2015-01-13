using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Core.Domain.Models;
using Core.Domain.Types; 

namespace Core.NHibernate.Mappings {
    
    
    public class TaskMap : ClassMap<Task> {
        
        public TaskMap() {
			Table("Tasks");
			LazyLoad();
			Id(x => x.Id).GeneratedBy.Identity().Column("TaskId");
			References(x => x.Category).Column("CategoryId");
			Map(x => x.Name).Column("Name").Not.Nullable();
			Map(x => x.Description).Column("Description").Not.Nullable();
			Map(x => x.Status).Column("Status").CustomType<TaskStatus>()
                .Not.Nullable();
        }
    }
}
