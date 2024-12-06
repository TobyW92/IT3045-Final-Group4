using Microsoft.AspNetCore.Mvc;
using IT3045_Final_Group4.Data;
using IT3045_Final_Group4.Interfaces;
using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : Controller
    {
        private readonly ILogger<GameController> _logger;
    
        private readonly IGameContextDAO _context;

        public GameController(ILogger<GameController> logger, IGameContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
            public IActionResult Get()
            {
                return Ok(_context.GetAllGames());
           }

         [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var item = _context.GetGameById(id);
            if (item == null) {
                return NotFound(id);
            } else
            {
                return Ok(item);
            }

        }

        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            var result = _context.RemoveGameById(id);

            if (result == null) return NotFound(id);

            if (result == 0)
            {
                return StatusCode(500, "An erorr occoured while processing your request");
            }

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Game game)
        {
            var result = _context.UpdateGame(game);

            if (result == null) return NotFound(game.Id);

            if (result == 0)
            {
                return StatusCode(500, "An erorr occoured while processing your request");
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Game game)
        {
            if (game == null)
            {
                return BadRequest("Invalid Game data.");
            }
            
        }
    }
}