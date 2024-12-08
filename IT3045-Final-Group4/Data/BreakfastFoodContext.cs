using Microsoft.EntityFrameworkCore;
using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Data
{
    public class BreakfastFoodContext : DbContext
    {
        public BreakfastFoodContext(DbContextOptions<BreakfastFoodContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Models.BreakfastFood>().HasData(
                new Models.BreakfastFood
                {
                    Id = 1,
                    Name = "Pancakes",
                    Beverage = "Orange Juice",
                    Popular = true,
                    ServingSize = "Medium",  // Set ServingSize as Medium
                    Calories = 350
                },
                new Models.BreakfastFood
                {
                    Id = 2,
                    Name = "Waffles",
                    Beverage = "Coffee",
                    Popular = true,
                    ServingSize = "Large",  // Set ServingSize as Large
                    Calories = 400
                },
                new Models.BreakfastFood
                {
                    Id = 3,
                    Name = "Omelette",
                    Beverage = "Tea",
                    Popular = true,
                    ServingSize = "Small",  // Set ServingSize as Small
                    Calories = 250
                }
            );
        }

        public DbSet<Models.BreakfastFood> FavoriteBreakfastFoods { get; set; }
    }
}

