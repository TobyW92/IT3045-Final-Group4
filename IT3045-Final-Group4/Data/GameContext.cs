using Microsoft.EntityFrameworkCore;

namespace IT3045_Final_Group4.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Models.Game>().HasData(
                new Models.Game {Id = 1, Name = "Fallout 3", Developer = "Bethesda Game Studios", Genre = "Action RPG", ReleaseDate = "October 28, 2008"},
                new Models.Game {Id = 2, Name = "Fallout 4", Developer = "Bethesda Game Studios", Genre = "Action RPG", ReleaseDate = "November 10, 2015"},
                new Models.Game {Id = 3, Name = "The Elder Scrolls V: Skyrim", Developer = "Bethesda Game Studios", Genre = "Action RPG", ReleaseDate = "November 11, 2011"},
                new Models.Game {Id = 4, Name = "Baldur's Gate 3", Developer = "Larian Studios", Genre = "Adventure RPG", ReleaseDate = "August 3, 2023"},
                new Models.Game {Id = 5, Name = "Mass Effect 2", Developer = "Bioware", Genre = "Action RPG", ReleaseDate = "January 26, 2010"}
            );
        }

        public DbSet<Models.Game> Game { get; set; }
    }
}