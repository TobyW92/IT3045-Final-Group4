using Microsoft.EntityFrameworkCore;

namespace IT3045_Final_Group4.Data
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Models.Sample>().HasData(
                new Models.Sample { Id = 1, SampleName = "Toby" },
                new Models.Sample { Id = 2, SampleName = "Name2" },
                new Models.Sample { Id = 3, SampleName = "Name3" },
                new Models.Sample { Id = 4, SampleName = "Name4" }
            );
        }

        public DbSet<Models.Sample> Sample { get; set; }
    }
}