using System;
using System.Text;
using System.Collections.Generic;
using Core.Domain.Types;
using Core.Domain.Infrastructure;


namespace Core.Domain.Models {
    
    public class Task : Entity
    {
        public virtual Category Category { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual TaskStatus Status { get; set; }
    }
}
