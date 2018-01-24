using Microsoft.EntityFrameworkCore;

namespace TestAPI
{
    public static class LiftingDbContextFactory
    {
        public static LiftingDbContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LiftingDbContext>();
            optionsBuilder.UseMySQL(connectionString);

            var context = new LiftingDbContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }
    }
}
