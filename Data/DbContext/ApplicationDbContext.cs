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
    }
}