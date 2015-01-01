using System;
using System.Text;
using System.Collections.Generic;
using Core.Domain.Infrastructure;


namespace Core.Domain.Models {
    
    public class Category : Entity
    {
        public Category() {
			Tasks = new List<Task>();
        }
        public virtual string Name { get; set; }
        public virtual IList<Task> Tasks { get; set; }
    }
}
