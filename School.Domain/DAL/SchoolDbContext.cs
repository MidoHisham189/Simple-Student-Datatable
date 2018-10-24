using School.Domain.Entities;
using School.Domain.Entities.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.DAL
{
   public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {
            this.Configuration
                 .LazyLoadingEnabled = false;
        }
        public DbSet<Student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
        }
    }
}
