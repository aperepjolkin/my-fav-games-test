using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyFavoriteGames.Models
{
    public class Game
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }

        public double? Rating { get; set; }

        public int? RatingCount { get; set; }

        public string Url { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Game>(this);
    }
}
