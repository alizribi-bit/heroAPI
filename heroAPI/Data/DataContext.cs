using heroAPI.Enteties;
using Microsoft.EntityFrameworkCore;

namespace heroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
            
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }

    }
}
