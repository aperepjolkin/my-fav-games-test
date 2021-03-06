using AutoMapper;
using MyFavoriteGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFavoriteGames.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            //CreateMap<GameEntity, GameEntityDTO>();
            CreateMap<GameEntityDTO, GameEntity>();
        }
    }
}
