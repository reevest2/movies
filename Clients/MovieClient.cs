using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using movies.Models;

namespace movies.Clients
{
    public class MovieClient
    {
        public async Task<List<Movie>> GetAll()
        {
            var restClient = new RestClient();

            var request = new RestRequest("https://movieapi20210928214652.azurewebsites.net/");
            var response = await restClient.ExecuteAsync<List<Movie>>(request);
            return response.Data;
        }
    }
}
