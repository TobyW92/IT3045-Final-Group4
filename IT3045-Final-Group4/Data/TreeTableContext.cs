using Microsoft.EntityFrameworkCore;
using IT3045_Final_Group4.Models;



namespace IT3045_Final_Group4.Data
{
    public class TreeTableContext : DbContext
    {
        public TreeTableContext(DbContextOptions<TreeTableContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Models.TreeTableModel>().HasData(
                new Models.TreeTableModel { Id = 1, TreeType = "Oak", Height = 20.5, 
                    BroughtBy = "Alice", Email = "alice@example.com", PhoneNumber = "123-456-7890",
                    Birthday = "1990-05-15" },
                new Models.TreeTableModel { Id = 2, TreeType = "Pine", Height = 30.0, 
                    BroughtBy = "Bob", Email = "bob@example.com", PhoneNumber = "987-654-3210", 
                    Birthday = "1985-03-20" },
                new Models.TreeTableModel { Id = 3, TreeType = "Maple", Height = 25.3, 
                    BroughtBy = "Charlie", Email = "charlie@example.com", PhoneNumber = "456-789-0123",
                    Birthday = "2000-08-10" },
                new Models.TreeTableModel { Id = 4, TreeType = "Birch", Height = 15.7, 
                    BroughtBy = "David", Email = "david@example.com", PhoneNumber = "321-654-9870", 
                    Birthday = "1995-12-25" },
                new Models.TreeTableModel { Id = 5, TreeType = "Cedar", Height = 18.2, 
                    BroughtBy = "Eve", Email = "eve@example.com", PhoneNumber = "213-546-7890", 
                    Birthday = "1988-11-05" }
             );
        }

        public DbSet<Models.TreeTableModel> Trees { get; set; }

    }
}