using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlExample.Data.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateTIme { get; set; } = DateTime.UtcNow;

        public DateTime? UpdateTIme { get; set; }

    }
}
