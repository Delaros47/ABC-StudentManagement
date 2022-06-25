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
        public DbSet<Incentive> Incentives { get; set; }
        public DbSet<Quota> Quotas { get; set; }
        public DbSet<GuidanceCounselor> GuidanceCounselors { get; set; }
        public DbSet<ClassGroup> ClassGroups { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<FamilyIntimacy> FamilyIntimacies { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<DiscountType> DiscountTypes { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<SchoolService> SchoolServices { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SpecialCode> SpecialCodes { get; set; }
        public DbSet<Cash> Cashes { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }




    }
}
