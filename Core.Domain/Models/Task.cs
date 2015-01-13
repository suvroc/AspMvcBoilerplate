using System;
using System.Text;
using System.Collections.Generic;
using Core.Domain.Types;
using Core.Domain.Infrastructure;
using System.ComponentModel.DataAnnotations;


namespace Core.Domain.Models {
    
    public class Task : Entity
    {
        public virtual Category Category { get; set; }
        [StringLength(10)]
        public virtual string Name { get; set; }
        [StringLength(10)]
        public virtual string Description { get; set; }
        public virtual TaskStatus Status { get; set; }
    }
}
