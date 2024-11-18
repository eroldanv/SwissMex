﻿using Microsoft.EntityFrameworkCore;
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
                new Category { Id = 1, Name = "Siembra", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Cosecha", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Aspersión", DisplayOrder = 3 }

            );
        }
    }
}
