using MyFavoriteGames.Models;
using MyFavoriteGames.Reposiotry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFavoriteGames.Services
{
    public class GameService : IGameService
    {
        private IGameRepository _gameRepository;
        private IGameIGDbAPIService _apiGameServie;
        public GameService(IGameRepository gameRepository, IGameIGDbAPIService apiGameServie)
        {
            _gameRepository = gameRepository;
            _apiGameServie = apiGameServie;
        }
        //public void AddRaiting(GameEntity game, int rating) {

        //    if (game != null) {
        //        // Only one rating per email is allowed.
        //        if (string.IsNullOrEmpty(game.Email))
        //            game.Ratings.Add(new RatingEntity() {
        //                Rate = rating
        //            });
        //    }
        //}
        public GameEntity FindGameInDatabseByID(int gameId)
        {
            var gameToBeUpdated = _gameRepository.GetById(gameId);
            if (gameToBeUpdated != null)
            {
                return gameToBeUpdated;
            }
            else
            {
                AddGameToDatabase(gameId);
                return _gameRepository.GetById(gameId);
            }

        }

        public void AddGameToDatabase(int newGameData)
        {
           // Find a game in public game service.
            var getNewGame = _apiGameServie.GetGameById(newGameData);
            if  (getNewGame != null) {
                GameEntity newGame = new GameEntity()
                {
                    PublicGameID = Convert.ToInt32(getNewGame.Id),
                    Title = getNewGame.Name
                };
                _gameRepository.Insert(newGame);
                _gameRepository.Save();
            }

        }

        public void AddRaiting(GameEntity game, int rating)
        {
            var findGame = _gameRepository.GetById(game.PublicGameID);
            if (string.IsNullOrEmpty(game.Email))
                if (findGame == null)
                {
                    findGame.Email = game.Email;
                    findGame.Comment = game.Comment;
                    findGame.Ratings.Add(new RatingEntity()
                    {
                        Rate = rating
                    });
                }

        }
  
    }
}
