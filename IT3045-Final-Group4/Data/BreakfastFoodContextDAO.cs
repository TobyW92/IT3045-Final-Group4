using IT3045_Final_Group4.Interfaces;
using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Data
{
    public class BreakfastFoodContextDAO : IBreakfastFoodContextDAO
    {

        private BreakfastFoodContext _context;
        public BreakfastFoodContextDAO(BreakfastFoodContext context)
        {
            _context = context;
        }

        public List<FavoriteBreakfastFood> GetAllItems()
        {
            return _context.FavoriteBreakfastFoods.ToList();
        }

        public FavoriteBreakfastFood GetItemById(int id)
        {
            return _context.FavoriteBreakfastFoods.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveItemById(int id)
        {
            var food = this.GetItemById(id);

            if (food == null) return null;

            try
            {
                _context.FavoriteBreakfastFoods.Remove(food);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public int? UpdateItem(FavoriteBreakfastFood item)
        {
            var itemToUpdate = this.GetItemById(item.Id);

            if (itemToUpdate == null) return null;

            itemToUpdate.Name = item.Name;
            itemToUpdate.Beverage = item.Beverage;
            itemToUpdate.Popular = item.Popular;
            itemToUpdate.ServingSize = item.ServingSize;
            itemToUpdate.Calories = item.Calories;


            try
            {
                _context.FavoriteBreakfastFoods.Update(itemToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? Add(FavoriteBreakfastFood item)
        {
            var itemToAdd = _context.FavoriteBreakfastFoods.Where(x => x.Name.Equals(item.Name)).FirstOrDefault();

            if (itemToAdd != null) return null;

            try
            {
                _context.FavoriteBreakfastFoods.Add(item);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
    }
}
