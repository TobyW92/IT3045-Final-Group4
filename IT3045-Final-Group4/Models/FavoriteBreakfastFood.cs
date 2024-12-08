namespace IT3045_Final_Group4.Models
{
    public enum ServingSize
    {
        Small = 1,
        Medium = 2,
        Large = 3
    }

    public class FavoriteBreakfastFood
    {
        // Primary Key
        public int Id { get; set; }

        // Name of the breakfast food
        public string Name { get; set; }

        // Beverage served with the food
        public string Beverage { get; set; }

        // Is the food considered popular?
        public bool Popular { get; set; }

        // Serving size (e.g., "Small", "Medium", "Large")
        public ServingSize ServingSize { get; set; }  // Changed from string to ServingSize enum

        // Calories in the food item
        public int Calories { get; set; }
    }
}
