using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Interfaces
{
    public interface IBreakfastFoodContextDAO
    {
        List<FavoriteBreakfastFood> GetAllItems();
        FavoriteBreakfastFood GetItemById(int id);

        int? RemoveItemById(int id);

        int? UpdateItem(FavoriteBreakfastFood item);

        int? Add(FavoriteBreakfastFood item);
    }
}
