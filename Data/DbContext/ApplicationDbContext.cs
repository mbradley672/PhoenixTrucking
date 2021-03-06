using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.DbContext {
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite(@"Data Source=pfs.db");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyPosition> CompanyPositions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<PayType> PayTypes { get; set; }
        public DbSet<Truck> Trucks { get; set; }
    }
}