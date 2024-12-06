using Microsoft.AspNetCore.Mvc;
using IT3045_Final_Group4.Data;
using IT3045_Final_Group4.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045_Final_Group4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreeTableController : ControllerBase
    {
        private readonly ILogger<TreeTableController> _logger;
        private readonly TreeTableContext _context;

        public TreeTableController(ILogger<TreeTableController> logger, TreeTableContext context)
        {
            _logger = logger;
            _context = context;
        }

        // READ - GET all trees
        [HttpGet]
        public IActionResult Get()
        {
            var trees = _context.Trees.Take(5).ToList();
            return Ok(trees);
        }

        // READ - GET a tree by id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tree = _context.Trees.FirstOrDefault(t => t.Id == id);
            if (tree == null)
            {
                return NotFound(new { message = $"Tree with ID {id} not found." });
            }
            return Ok(tree);
        }

        // CREATE - POST to add a new tree
        [HttpPost]
        public IActionResult Post([FromBody] TreeTable tree)
        {
            if (tree == null)
            {
                return BadRequest("Invalid tree data.");
            }
            _context.Trees.Add(tree);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = tree.Id }, tree);
        }

        // UPDATE - PUT to update an existing tree
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TreeTable tree)
        {
            if (tree == null || tree.Id != id)
            {
                return BadRequest("Tree ID mismatch.");
            }
            var existingTree = _context.Trees.FirstOrDefault(t => t.Id == id);
            if (existingTree == null)
            {
                return NotFound(new { message = $"Tree with ID {id} not found." });
            }
            existingTree.TreeType = tree.TreeType;
            existingTree.Height = tree.Height;
            existingTree.BroughtBy = tree.BroughtBy;
            existingTree.Email = tree.Email;
            existingTree.PhoneNumber = tree.PhoneNumber;
            existingTree.Birthday = tree.Birthday;
            _context.Trees.Update(existingTree);
            _context.SaveChanges();
            return Ok(existingTree);
        }

        // DELETE - DELETE a tree by id
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var tree = _context.Trees.FirstOrDefault(t => t.Id == id);
            if (tree == null)
            {
                return NotFound(new { message = $"Tree with ID {id} not found." });
            }
            _context.Trees.Remove(tree);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
