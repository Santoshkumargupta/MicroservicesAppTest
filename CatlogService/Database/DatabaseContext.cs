using Microsoft.EntityFrameworkCore;

namespace CatlogService.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> option) : base(option) { }

        public DbSet<Product> Products { get; set; }


    }
}
