using Microsoft.EntityFrameworkCore;

namespace TestDatabase
{
    public static class MyDbContextExtension
    {
        public static void Initialize(this MyDbContext context)
        {
            context.Database.SetCommandTimeout(TimeSpan.FromMinutes(5));
            context.Database.Migrate();
        }
    }
}
