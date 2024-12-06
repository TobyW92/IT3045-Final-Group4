using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Interfaces
{
    public interface ITeamMemberContextDAO
    {
        List<TeamMember> GetAllMembers();
        TeamMember GetMemberById(int id);
        void AddMember(TeamMember teamMember);
        void UpdateMember(TeamMember teamMember);
        void DeleteMember(int id);
    }
}
