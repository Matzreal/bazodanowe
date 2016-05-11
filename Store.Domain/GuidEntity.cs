using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public abstract class GuidEntity : Entity<Guid>
    {
        protected GuidEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
