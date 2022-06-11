using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class StudentManagementContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QI6H2EA;Initial Catalog=StudentManagementDb;Integrated Security=True;");
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<FamilyInformation> FamilyInformations { get; set; }
        public DbSet<CancelReason> CancelReasons { get; set; }
        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }


    }
}
