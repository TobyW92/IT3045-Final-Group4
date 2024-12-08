namespace IT3045_Final_Group4.Models
{

    public class BreakfastFood
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
        public string ServingSize { get; set; }

        // Calories in the food item
        public int Calories { get; set; }
    }
}
