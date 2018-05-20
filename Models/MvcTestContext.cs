using Microsoft.EntityFrameworkCore;

namespace MVCTest.Models
{
    public class MvcTestContext : DbContext
    {
        public MvcTestContext(DbContextOptions<MvcTestContext> options)
            : base(options)
            {
            }
            
            public DbSet<MVCTest.Models.Movie> Movie {get; set;}
    }
}