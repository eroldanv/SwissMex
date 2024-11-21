using Microsoft.EntityFrameworkCore;
using SwissMex.RazorPages.Models;

namespace SwissMex.RazorPages.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData([
                new Category { Id = 1, Name = "Siembra", DisplayOrder=1 },
                new Category { Id = 2, Name = "Cosecha", DisplayOrder=2 },
                new Category { Id = 3, Name = "Aspersión", DisplayOrder=3 }
                ]);
        }

        public DbSet<Category> Categories { get; set; }

    }
}
