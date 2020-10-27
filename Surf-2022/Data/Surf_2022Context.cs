using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Surf_2022.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Surf_2022.Data
{
    public class Surf_2022Context : IdentityDbContext<IdentityUser>
    {
        public Surf_2022Context (DbContextOptions<Surf_2022Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Surf_2022.Models.Surfspots> Surfspots { get; set; }
        public DbSet<Surf_2022.Models.RegisterViewModel> RegisterViewModels { get; set; }
    }
}
