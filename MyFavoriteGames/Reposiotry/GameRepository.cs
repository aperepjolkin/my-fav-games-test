using Microsoft.EntityFrameworkCore;
using MyFavoriteGames.DAL;
using MyFavoriteGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFavoriteGames.Reposiotry
{
    public class GameRepository : IGameRepository, IDisposable
    {

        private readonly GameContext _context;
        // Create a field to store the mapper object
     
        public GameRepository(GameContext context)
        {
            _context = context;
        }
        public void Delete(int GameID)
        {
            GameEntity game = _context.Games.SingleOrDefault(g => g.PublicGameID == GameID);
            _context.Games.Remove(game);
        }

        public IEnumerable<GameEntity> GetAll()
        {
            return _context.Games.ToList();
        }

        public GameEntity GetById(int GameID)
        {
            return _context.Games.SingleOrDefault(g => g.PublicGameID == GameID);
        }

        public void Insert(GameEntity game)
        {
            _context.Games.Add(game);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(GameEntity game)
        {
            _context.Entry(game).State = EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
    }
}
