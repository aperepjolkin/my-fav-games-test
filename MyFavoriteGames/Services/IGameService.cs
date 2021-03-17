using IGDB.Models;
using MyFavoriteGames.Models;

namespace MyFavoriteGames.Services
{
    public interface IGameService
    {
        public void AddRaiting(GameEntity game, int rating);
        public GameEntity FindGameInDatabseByID(int gameId);

        public void AddGameToDatabase(int gameId);
    }
}