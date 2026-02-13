using backened_for_intern.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backened_for_intern.Data
{
     
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<User> Users { get; set; }
        public DbSet<ProjectItem> ProjectItems { get; set; }

    }


}

