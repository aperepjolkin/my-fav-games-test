using Microsoft.AspNetCore.Mvc;
using MyFavoriteGames.Reposiotry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using MyFavoriteGames.Models;
using Newtonsoft.Json;

namespace MyFavoriteGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private IGameRepository _gameRepository;
        // Create a field to store the mapper object
        private readonly IMapper _mapper;
        public GamesController(
            IGameRepository gameRepository, 
            IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public string Post([FromBody] GameEntityDTO game)
        {
            var model = _mapper.Map<GameEntity>(game);
            
            _gameRepository.Update(model);
           
            return JsonConvert.SerializeObject(model);
        }
      

    }
}
