using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Infrastructure
{
    public interface IKeyRepository<TEntity, TPrimaryKey>
    {
        TEntity GetById(TPrimaryKey id);
    }
}
