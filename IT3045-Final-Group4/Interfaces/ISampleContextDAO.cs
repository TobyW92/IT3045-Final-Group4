using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Interfaces
{
    public interface ISampleContextDAO
    {
        List<Sample> GetAllItems();
        Sample GetItemById(int id);
    }
}
