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
    }
}
