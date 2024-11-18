using Microsoft.AspNetCore.Mvc;
using IT3045_Final_Group4.Data;
using IT3045_Final_Group4.Interfaces;

namespace IT3045_Final_Group4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {

        private readonly ILogger<SampleController> _logger;

        private readonly ISampleContextDAO _context;

        public SampleController(ILogger<SampleController> logger, ISampleContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllItems());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var item = _context.GetItemById(id);
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
            var item = _context.RemoveItemById(id);
            if (item == null) return NotFound(id);
            if (string.IsNullOrEmpty(item.SampleName))
            {
                return StatusCode(500, "An erorr occoured while processing your request");
            }
            return Ok();
        }
    }
}
