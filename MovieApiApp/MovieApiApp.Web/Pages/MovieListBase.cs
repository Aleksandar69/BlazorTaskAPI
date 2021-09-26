using Microsoft.AspNetCore.Components;
using MovieApiApp.Models;
using MovieApiApp.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApiApp.Web.Pages
{
    public class MovieListBase : ComponentBase
    {

        [Inject]
        public IMovieService MovieService { get; set; }
        public IEnumerable<MovieQuery> MovieList { get; set; }
        protected string QuerySearch {  get; set; }

        protected async Task SearchMovies()
        {
            if (QuerySearch != null)
            {
                MovieList = (await MovieService.GetMovies(QuerySearch)).results.ToList();
            }
            else
            {
                throw new NullReferenceException("Please enter something in search field");
            }
        }
    }
}
