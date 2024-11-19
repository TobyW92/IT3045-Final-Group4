using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Interfaces
{
    public interface ITeamMemberContextDAO
    {
        List<TeamMember> GetAllItems();
        TeamMember GetItemById(int id);
    }
}
