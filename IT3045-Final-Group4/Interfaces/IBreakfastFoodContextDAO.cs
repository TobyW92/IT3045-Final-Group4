using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Interfaces
{
    public interface IBreakfastFoodContextDAO
    {
        List<BreakfastFood> GetAllItems();
        BreakfastFood GetItemById(int id);

        int? RemoveItemById(int id);

        int? UpdateItem(BreakfastFood item);

        int? Add(BreakfastFood item);
    }
}
