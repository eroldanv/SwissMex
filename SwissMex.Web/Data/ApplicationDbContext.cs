using Microsoft.EntityFrameworkCore;
using SwissMex.Web.Models;

namespace SwissMex.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sci-Fi", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Dorama", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Action", DisplayOrder = 3 }

            );
        }
    }
}
