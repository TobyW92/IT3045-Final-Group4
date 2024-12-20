using Microsoft.AspNetCore.Mvc;
using IT3045_Final_Group4.Data;
using IT3045_Final_Group4.Interfaces;
using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {

        private readonly ILogger<TeamMemberController> _logger;

        private readonly TeamMemberContext _context;

        public TeamMemberController(ILogger<TeamMemberController> logger, TeamMemberContext context)
        {
            _logger = logger;
            _context = context;
        }

        // READ - GET all team members
        [HttpGet]
       public IActionResult Get()
        {
            var teamMembers = _context.TeamMembers.Take(5).ToList();
            return Ok(teamMembers);
        }

        // READ - GET a team member by id
        [HttpGet("id")]
         public IActionResult GetById(int id)
        {
            var teamMember = _context.TeamMembers.FirstOrDefault(tm => tm.Id == id);
            if (teamMember == null)
            {
                return NotFound(new { message = $"Team member with ID {id} not found." });
            }
            return Ok(teamMember);
        }

        // CREATE - POST to add a new team member
        [HttpPost]
        public IActionResult Post([FromBody] TeamMember teamMember)
        {
            if (teamMember == null)
            {
                return BadRequest("Invalid team member data.");
            }
            _context.TeamMembers.Add(teamMember);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = teamMember.Id }, teamMember);
        }

        // UPDATE - PUT to update an existing team member
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TeamMember teamMember)
        {
            if (teamMember == null || teamMember.Id != id)
            {
                return BadRequest("Team member ID mismatch.");
            }
            var existingMember = _context.TeamMembers.FirstOrDefault(tm => tm.Id == id);
            if (existingMember == null)
            {
                return NotFound(new { message = $"Team member with ID {id} not found." });
            }
            existingMember.FullName = teamMember.FullName;
            existingMember.Birthdate = teamMember.Birthdate;
            existingMember.CollegeProgram = teamMember.CollegeProgram;
            existingMember.YearInProgram = teamMember.YearInProgram;
            _context.TeamMembers.Update(existingMember);
            _context.SaveChanges();
            return Ok(existingMember);
        }

        // DELETE - to delete a team member by id
        [HttpDelete("id")]
        public IActionResult DeleteById(int id)
        {
            var teamMember = _context.TeamMembers.FirstOrDefault(tm => tm.Id == id);
            if (teamMember == null)
            {
                return NotFound(new { message = $"Team member with ID {id} not found." });
            }
            _context.TeamMembers.Remove(teamMember);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
