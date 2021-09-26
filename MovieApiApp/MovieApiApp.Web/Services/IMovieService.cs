using MovieApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApiApp.Web.Services
{
    public interface IMovieService
    {
        Task<QueryResults> GetMovies(string queryString);
        Task<Movie> GetMovie(int id);
    }
}
