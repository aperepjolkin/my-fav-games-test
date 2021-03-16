using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFavoriteGames.Models
{
    public class GameEntity
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }

        public int Rating { get; set; }

        public string Email { get; set; }
        [Column(TypeName  = "nvarchar(250)")]
        public string Comment { get; set; }
    }
}
