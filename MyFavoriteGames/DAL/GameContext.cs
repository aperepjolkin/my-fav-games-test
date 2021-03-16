using Microsoft.EntityFrameworkCore;
using MyFavoriteGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFavoriteGames.DAL
{
    public class GameContext : DbContext
    {

        public GameContext()
        {

        }
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {

        }

        public DbSet<GameEntity> Games { get; set; }

    }
}
