using DatabasesEntities.Models;
using DatabasesEntities.Models.Enumerations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatabasesEntities.Context
{
    public class SysKitContext : DbContext, ISysKitContext
    {
        #region Constructors

        public SysKitContext(DbContextOptions options) : base(options) { }

        #endregion Constructors

        #region DbSets

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        #endregion DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Company)
            //    .WithMany(c => c.Employees)
            //    .HasConstraintName("Company_Employee_FK");

            //modelBuilder.Entity<Company>()
            //    .HasOne(c => c.CreatedByEmployee)
            //    .WithOne(e => e.Company)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .HasForeignKey<Company>(d => d.Id)
            //    .HasConstraintName("CreatedByEmployee_FK");

            //modelBuilder.Entity<Company>()
            //    .HasOne(c => c.ModifiedByEmployee)
            //    .WithOne(e => e.Company)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .HasForeignKey<Company>(d => d.Id)
            //    .HasConstraintName("ModifiedByEmployee_FK");


            // This gets generated into a new Migration
            // So when that migration runs, it will do the insert
            // !!!
            var company = new Company
            {
                Id = 1,
                Name = "SysKit",
                VatId = "Vat Id",
                CreatedByEmployeeId = 1
            };

            var employee = new Employee
            {
                 Id = 1,
                 CompanyId = 1,
                 CreatedByEmployeeId = 1,
                 FirstName = "David",
                 LastName = "Čubela"                 
            };

            modelBuilder.Entity<Company>()
                .HasData(company);

            modelBuilder.Entity<Employee>()
                .HasData(employee);
        }
    }
}
