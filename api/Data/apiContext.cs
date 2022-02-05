#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext (DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
