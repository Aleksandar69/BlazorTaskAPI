using MovieApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MovieApiApp.Web.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient httpClient;

        public MovieService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Movie> GetMovie(int id)
        {
            return await httpClient.GetFromJsonAsync<Movie>($"movie/{id}?api_key=03b8572954325680265531140190fd2a");
        }

        public async Task<QueryResults> GetMovies(string queryString)
        {
            return await httpClient.GetFromJsonAsync<QueryResults>("search/movie?api_key=03b8572954325680265531140190fd2a&query=" + queryString);
            int i = 1;
        }
    }
}
