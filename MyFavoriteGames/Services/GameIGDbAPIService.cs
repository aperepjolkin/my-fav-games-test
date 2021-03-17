using IGDB.Models;
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
    public class GameIGDbAPIService : IGameIGDbAPIService
    {

        private readonly string CLIENT_ID = "lo19qy9izg5f0y1afhhhdtbp5gncvx";
        private readonly string CLIENT_SECRET = "g5be9aemm0l5z4xwgo64upt8he37xo";
        private Game[] gamesList = null;

        public Game GetGameById(int id)
        {
            var game = GetGameByIdFromPublicService(id);

            var jsonGame = JsonConvert.SerializeObject(game.Result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
            return JsonConvert.DeserializeObject<Game>(jsonGame.Substring(1, jsonGame.Length - 2));
        }

        public string GetGamesList()
        {
            var json = GetTopGameListFromPublicService();
            return JsonConvert.SerializeObject(json.Result, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
        }

        public string GetTwentyGamesList()
        {
            var json = GetTwentyGamesListFromPublicService();
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
            try {
                var igdb = new IGDBClient(CLIENT_ID, CLIENT_SECRET);
                gamesList = await igdb.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: "fields id,name,rating,first_release_date,total_rating; limit 5; sort rating asc;");
            }
            catch (Exception ex)
            {
                // todo logger
            }
            return gamesList;
        }

        private async Task<Game[]> GetTwentyGamesListFromPublicService()
        {
            try
            {
                var igdb = new IGDBClient(CLIENT_ID, CLIENT_SECRET);
                gamesList = await igdb.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: "fields id,name,rating,first_release_date,total_rating; limit 20; sort rating asc;");
            }
            catch (Exception ex)
            {
                // todo logger
            }
            return gamesList;
        }

        private async Task<Game[]> GetGameByIdFromPublicService(int id)
        {
           
            try
            {
                var igdb = new IGDBClient(CLIENT_ID, CLIENT_SECRET);
                gamesList = await igdb.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: $"fields id,name,rating,first_release_date,total_rating; where id = {id};");
            }
            catch (Exception ex)
            {
                // todo logger
            }
            return gamesList;
        }
    }
}
