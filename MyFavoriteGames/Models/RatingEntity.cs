using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFavoriteGames.Models
{
    public class RatingEntity
    {
        [Key]
        public int ID { get; set; }

        public int Rate { get; set; }
    }
}
