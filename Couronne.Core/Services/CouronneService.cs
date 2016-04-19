using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Couronne.Core.Models.DTO;
using Newtonsoft.Json;

namespace Couronne.Core.Services
{
    public class CouronneService
    {
        readonly string baseUri = "http://couronneapi.azurewebsites.net";

        public async Task<List<Player>> GetTopPlayersYear()
        {
            string uri = baseUri + "/api/Player/gethighscorelist";
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<List<Player>>(response);
            }
        }


        public async Task<List<Player>> GetTopPlayersMonth(string month)
        {
            string uri = baseUri + "/api/Player/gethighscorelistbymonth?month=" + month;
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<List<Player>>(response);
            }
        }

    }
}
