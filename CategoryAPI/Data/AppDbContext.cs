// Data/AppDbContext.cs
using System;
using Microsoft.EntityFrameworkCore;

namespace CategoryAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }  // Represents the Categories table in the database
    }
}
