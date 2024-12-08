using Microsoft.EntityFrameworkCore;
using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Data
{
    public class BreakfastFoodContext : DbContext
    {
        public BreakfastFoodContext(DbContextOptions<BreakfastFoodContext> options) : base(options) { }

        public DbSet<FavoriteBreakfastFood> FavoriteBreakfastFoods { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavoriteBreakfastFood>().HasData(
                new FavoriteBreakfastFood
                {
                    Id = 1,
                    Name = "Pancakes",
                    Beverage = "Orange Juice",
                    Popular = true,
                    ServingSize = ServingSize.Medium,  // Set ServingSize as Medium
                    Calories = 350
                },
                new FavoriteBreakfastFood
                {
                    Id = 2,
                    Name = "Waffles",
                    Beverage = "Coffee",
                    Popular = true,
                    ServingSize = ServingSize.Large,  // Set ServingSize as Large
                    Calories = 400
                },
                new FavoriteBreakfastFood
                {
                    Id = 3,
                    Name = "Omelette",
                    Beverage = "Tea",
                    Popular = true,
                    ServingSize = ServingSize.Small,  // Set ServingSize as Small
                    Calories = 250
                }
            );
        }
    }
}

