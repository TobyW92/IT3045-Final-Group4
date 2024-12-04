using IT3045_Final_Group4.Interfaces;
using IT3045_Final_Group4.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045_Final_Group4.Data
{
    public class TeamMemberContextDAO : ITeamMemberContextDAO
    {

        private readonly TeamMemberContext _context;
        public TeamMemberContextDAO(TeamMemberContext context)
        {
            _context = context;
        }

        public List<TeamMember> GetAllMembers()
        {
            return _context.TeamMembers.ToList();
        }

        public TeamMember GetMemberById(int id)
        {
            return _context.TeamMembers.Where(x => x.Id == id).FirstOrDefault();
        }

         public void AddMember(TeamMember teamMember)
        {
            _context.TeamMembers.Add(teamMember);
            _context.SaveChanges();
        }

        public void UpdateMember(TeamMember teamMember)
        {
            _context.TeamMembers.Update(teamMember);
            _context.SaveChanges();
        }

        public void DeleteMember(int id)
        {
            // find team member by id
            var member = _context.TeamMembers.FirstOrDefault(x => x.Id == id);
            if (member != null)
            {
                _context.TeamMembers.Remove(member);
                _context.SaveChanges();
            }
        }
    }
