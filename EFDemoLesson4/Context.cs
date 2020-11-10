using Microsoft.EntityFrameworkCore;
using System;

namespace EFDemoLesson4
{
    class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .LogTo(s => System.Diagnostics.Debug.WriteLine(s))
                .UseLazyLoadingProxies()
                .UseSqlServer(
                    @"server=.\SQLEXPRESS;" + // För att ansluta till MSSQL Express server
                    "database=SimpleSalesDatabase;" + // Skapar/ansluter till en specifik databas på servern
                    "trusted_connection=true;"  // För att använda Windows credentials
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Customer c = new Customer
            {
                Id = 1,
                FirstName = "Björn",
                LastName = "Strömberg",
                BonusPoints = 45000,
                Gender = Gender.Male
            };

            modelBuilder.Entity<Customer>().HasData(c);

            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 1,
                DateOfPurchase = DateTime.Now,
                CustomerId = 1,
            });
        }
    }
}
