using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Interfaces
{
    public interface IGameContextDAO
    {
        List<Game> GetAllGames();

        Game GetGameById(int id);

        int? RemoveGameById(int id);

        int? UpdateGame(Game game);

        int? Add(Game game);
    }
}