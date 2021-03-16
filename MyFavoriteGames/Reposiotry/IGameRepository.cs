using MyFavoriteGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFavoriteGames.Reposiotry
{
    public interface IGameRepository : IDisposable
    {
        IEnumerable<GameEntity> GetAll();
        GameEntity GetById(int EmployeeID);
        void Insert(GameEntity employee);
        void Update(GameEntity employee);
        void Delete(int EmployeeID);
        void Save();
    }
}
