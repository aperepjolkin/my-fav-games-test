using IGDB.Models;

namespace MyFavoriteGames.Services
{
    public interface IGameIGDbAPIService
    { 
        public string GetGamesList();
        public string GetTwentyGamesList();

        public Game GetGameById(int id);
   
    }
}