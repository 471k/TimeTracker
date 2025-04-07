using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Shared.Entities
{
    public class SoftDeletableEntity : BaseEntity
    {
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
