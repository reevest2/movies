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
        private readonly IRestClient _restClient;
        public MovieClient(IRestClient restClient) 
        {
            _restClient = restClient;
        }

        public async Task<List<Movie>> GetAll()
        {
            var request = new RestRequest("movie");
            var response = await _restClient.ExecuteAsync<List<Movie>>(request);
            return response.Data;
        }

        public async Task<Movie> Create(Movie movie)
        {
            var request = new RestRequest("movie", Method.POST);
            request.AddJsonBody(movie);
            var response = await _restClient.ExecuteAsync<Movie>(request);
            return response.Data;
        }
    }
}
