using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Surf_2022.Data
{
    public class IdentityUserContext : IdentityDbContext<IdentityUser>
    {
        public IdentityUserContext(DbContextOptions<IdentityUserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Surf_2022.Models.RegisterViewModel> RegisterViewModels { get; set; }
    }
}
