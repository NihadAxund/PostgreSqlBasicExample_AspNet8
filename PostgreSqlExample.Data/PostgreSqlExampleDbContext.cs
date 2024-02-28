using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlExample.Data
{
    public  class PostgreSqlExampleDbContext: DbContext
    {
        public PostgreSqlExampleDbContext(DbContextOptions<PostgreSqlExampleDbContext> options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostgreSqlExampleDbContext).Assembly);
        }
    }
}
