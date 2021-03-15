using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFavoriteGames.Services
{
    [Header("Accept", "application/json")]
    public interface IGDBApi
    {
      
            /// <summary>
            /// Your secret, private IGDB API token
            /// </summary>
            /// <value></value>
            [Header("client-id")]
            string ClientId { get; set; }

            /// <summary>
            /// Queries a standard IGDB endpoint with an APIcalypse query. See endpoints in <see cref="IGDB.IGDBClient.Endpoints" />.
            /// </summary>
            /// <param name="endpoint">The IGDB endpoint name to query, see <see cref="IGDB.IGDBClient.Endpoints" /></param>
            /// <param name="query">The APIcalypse query to send</param>
            /// <typeparam name="T">The IGDB.Models.* entity to deserialize the response for.</typeparam>
            /// <returns>Array of IGDB models of the specified type</returns>
            [Post("/{endpoint}")]
            Task<T[]> QueryAsync<T>([Path] string endpoint, [Body] string query = null);
        
    }
}
