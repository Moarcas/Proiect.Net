using Microsoft.EntityFrameworkCore;
using ProiectTest.Models;

namespace ProiectTest.Data
{
    public class ProiectTestContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public ProiectTestContext(DbContextOptions<ProiectTestContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // FLUENT API
            // One to many
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
        
            base.OnModelCreating(modelBuilder);
        }
    }
}