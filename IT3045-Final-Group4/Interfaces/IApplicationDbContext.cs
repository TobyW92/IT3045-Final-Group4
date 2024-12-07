using Microsoft.EntityFrameworkCore;
using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Sample> Sample { get; set; }
        DbSet<FavoriteBreakfastFood> FavoriteBreakfastFoods { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
