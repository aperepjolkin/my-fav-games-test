using MyFavoriteGames.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MyFavoriteGames.Services
{
    public class GameService
    {
        public string GetGamesList()
        {
            var json = GetTopGameListFromPublicService();
            return JsonConvert.SerializeObject(json.Result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
        }
        /// <summary>
        /// Read games json data from public service.
        /// </summary>
        /// <returns></returns>
        private async Task<Game[]> GetTopGameListFromPublicService()
        {
            Game[] gamesList = null;
            try {
                var igdb = new IGDBClient("lo19qy9izg5f0y1afhhhdtbp5gncvx", "g5be9aemm0l5z4xwgo64upt8he37xo");
                gamesList = await igdb.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: "fields id,name,rating; limit 5; sort rating desc;");
            }
            catch (Exception ex)
            {
                // todo logger
            }
            return gamesList;
        }
    }
}
