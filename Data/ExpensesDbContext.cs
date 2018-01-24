using Microsoft.EntityFrameworkCore;
using TestAPI.Data.Models;

namespace TestAPI.Data
{
    public class ExpensesDbContext : DbContext
    {
        public ExpensesDbContext(DbContextOptions options) : base(options) { }

        public DbSet<People> People { get; set; }
        public DbSet<AccountTypes> AccountTypes { get; set; }
        public DbSet<Accounts> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Accounts>()
                        .HasOne(p => p.AccountType);
        }
    }
}
