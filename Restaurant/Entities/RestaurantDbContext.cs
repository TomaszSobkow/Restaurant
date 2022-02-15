using Microsoft.EntityFrameworkCore;

namespace Restaurant.Entities

{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; } 
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Dish> Dishes { get; set; }

    }
}
