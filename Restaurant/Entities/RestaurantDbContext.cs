using Microsoft.EntityFrameworkCore;

namespace Restaurant.Entities

{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; } 
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Restaurant>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(35);
            
            modelBuilder.Entity<Dish>()
                .Property(d => d.Name)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
        }
        

    }
}
