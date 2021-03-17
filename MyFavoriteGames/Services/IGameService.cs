using IGDB.Models;
using MyFavoriteGames.Models;
using System.Collections.Generic;

namespace MyFavoriteGames.Services
{
    public interface IGameService
    {
        public void AddRaiting(GameEntity game, int rating);
        public GameEntity FindGameInDatabseByID(int gameId);

        public void AddGameToDatabase(int gameId);

        public List<GameEntity> GetAllGames();
    }
}