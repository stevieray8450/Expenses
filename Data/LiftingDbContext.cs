using Microsoft.EntityFrameworkCore;

namespace TestAPI
{
    public class ExpensesDbContext : DbContext
    {
        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options) : base(options) {}

        public DbSet<LegsWorkout> LegsWorkouts { get; set; } 
    }
}
