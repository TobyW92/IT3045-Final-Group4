using IT3045_Final_Group4.Interfaces;
using IT3045_Final_Group4.Models;
namespace IT3045_Final_Group4.Data
{
    public class GameContextDAO : IGameContextDAO
    {
        private GameContext _context;
        public GameContextDAO(GameContext context)
        {
            _context = context;
        }
        public List<Game> GetAllGames()
        {
            return _context.Game.ToList();
        }
        public Game GetGameById(int id)
        {
            return _context.Game.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
        public int? RemoveGameById(int id)
        {
            var game = this.GetGameById(id);
            if (game == null) return null;
            try
            {
                _context.Game.Remove(game);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int? UpdateGame(Game game)
        {
            var gameToUpdate = this.GetGameById(game.Id);
            if (gameToUpdate == null) return null;
            gameToUpdate.Name = game.Name;
            gameToUpdate.Developer = game.Developer;
            gameToUpdate.Genre = game.Genre;
            gameToUpdate.ReleaseDate = game.ReleaseDate;
            try
            {
                _context.Game.Update(gameToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int? Add(Game game)
        {
            var gameToAdd = _context.Game.Where(x => x.Name.Equals(game.Name)).FirstOrDefault();
            if (gameToAdd != null) return null;
            try
            {
                _context.Game.Add(game);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
    }
}