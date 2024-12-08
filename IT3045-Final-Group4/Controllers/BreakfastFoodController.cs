using Microsoft.AspNetCore.Mvc;
using IT3045_Final_Group4.Data;
using IT3045_Final_Group4.Models;
using IT3045_Final_Group4.Interfaces;

namespace IT3045_Final_Group4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BreakfastFoodController : ControllerBase
    {
        private readonly IBreakfastFoodContextDAO _context;

        // Constructor that initializes the context
        public BreakfastFoodController(IBreakfastFoodContextDAO context)
        {
            _context = context;
        }

        // GET method to retrieve data
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllItems());
        }

        // GET by ID
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var item = _context.GetItemById(id);
            if (item == null)
            {
                return NotFound(id);
            }
            else
            {
                return Ok(item);
            }

        }

        // POST method to add a new favorite breakfast food
        [HttpPost]
        public IActionResult Post(BreakfastFood food)
        {
            var result = _context.Add(food);

            if (result == null) return StatusCode(500, "Item with that name already exists");

            if (result == 0) return StatusCode(500, "An error occured while processign your request");

            return Ok();
        }

        // PUT method to update an existing favorite breakfast food
        [HttpPut]
        public IActionResult Put(BreakfastFood food)
        {

            var result = _context.UpdateItem(food);

            if (result == null) return NotFound(food.Id);

            if (result == 0)
            {
                return StatusCode(500, "An erorr occoured while processing your request");
            }

            return Ok();
        }

        // Deletes the food item from the database
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveItemById(id);

            if (result == null) return NotFound(id);

            if (result == 0)
            {
                return StatusCode(500, "An erorr occoured while processing your request");
            }

            return Ok();
        }
    }
}