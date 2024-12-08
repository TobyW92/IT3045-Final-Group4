using Microsoft.AspNetCore.Mvc;
using IT3045_Final_Group4.Data;
using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteBreakfastFoodController : ControllerBase
    {
        private readonly BreakfastFoodContext _context;

        // Constructor that initializes the context
        public FavoriteBreakfastFoodController(BreakfastFoodContext context)
        {
            _context = context;
        }

        // GET method to retrieve data
        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id == null || id == 0)
            {
                return Ok(_context.FavoriteBreakfastFoods.Take(5));
            }
            var item = _context.FavoriteBreakfastFoods.Find(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        // POST method to add a new favorite breakfast food
        [HttpPost]
        public IActionResult Post(FavoriteBreakfastFood food)
        {
            _context.FavoriteBreakfastFoods.Add(food);
            _context.SaveChanges();
            // Returns the created food item with its assigned ID
            return CreatedAtAction(nameof(Get), new { id = food.Id }, food);
        }

        // PUT method to update an existing favorite breakfast food
        [HttpPut("{id}")]
        public IActionResult Put(int id, FavoriteBreakfastFood food)
        {
            // Finds the existing food item by id
            var existingFood = _context.FavoriteBreakfastFoods.Find(id);
            if (existingFood == null) return NotFound();

            // Updates the existing food item's properties
            existingFood.Name = food.Name;
            existingFood.Beverage = food.Beverage;
            existingFood.Popular = food.Popular;
            existingFood.ServingSize = food.ServingSize;  // Handling the enum correctly
            existingFood.Calories = food.Calories;

            // Saves the changes to the database
            _context.SaveChanges();
            return NoContent();
        }

        // Deletes the food item from the database
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var food = _context.FavoriteBreakfastFoods.Find(id);
            if (food == null) return NotFound();

            _context.FavoriteBreakfastFoods.Remove(food);
            _context.SaveChanges();
            return NoContent();
        }
    }
}