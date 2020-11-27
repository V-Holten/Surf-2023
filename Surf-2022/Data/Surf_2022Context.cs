using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Surf_2022.Models;


namespace Surf_2022.Data
{
    public class Surf_2022Context : DbContext
    {
        public Surf_2022Context (DbContextOptions<Surf_2022Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Surfspots> Surfspots { get; set; }
        
    }
}
