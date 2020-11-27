using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SurfAPI.Data
{
    public class RootContext : DbContext
    {
        public RootContext(DbContextOptions<RootContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Models.Root> Roots { get; set; }
    }

}
