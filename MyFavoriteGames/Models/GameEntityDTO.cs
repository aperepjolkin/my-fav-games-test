using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFavoriteGames.Models
{
    public class GameEntityDTO
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public int Rating { get; set; }

        public string Email { get; set; }
   
        public string Comment { get; set; }
    }
}
