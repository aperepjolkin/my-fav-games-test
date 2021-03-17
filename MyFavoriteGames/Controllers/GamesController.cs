using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using MyFavoriteGames.Models;
using Newtonsoft.Json;
using MyFavoriteGames.Services;
using System;

namespace MyFavoriteGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;
        // Create a field to store the mapper object
        private readonly IMapper _mapper;
        public GamesController(
            IGameService gameService, 
            IMapper mapper)
        {
            _gameService = gameService;
            _mapper = mapper;
        }

        [HttpPost]
        public string Post([FromBody] GameEntityDTO game)
        {
            var gameObj = _gameService.FindGameInDatabseByID(game.ID);
            if (gameObj != null)
            {
                // Add rating db record 
                var model = _mapper.Map<GameEntity>(game);
                _gameService.AddRaiting(model,game.Rating);
            }
            return JsonConvert.SerializeObject("ok");

        }

        [HttpGet]
        [Route("{id:int}")]
        public string Get(int id)
        {
            var gameObj = _gameService.FindGameInDatabseByID(id);
            if (gameObj != null)
            {
                return JsonConvert.SerializeObject(gameObj);
            }
            return JsonConvert.SerializeObject(false);

        }

        [HttpGet]
        [Route("{name}")]
        public string GetAll()
        {
            var gamesList = _gameService.GetAllGames();
            if (gamesList != null)
            {
                return JsonConvert.SerializeObject(gamesList);
            }
            return JsonConvert.SerializeObject(false);

        }

    }
}
