using Microsoft.AspNetCore.Components;
using MovieApiApp.Models;
using MovieApiApp.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApiApp.Web.Pages
{
    public class MovieDetailsBase : ComponentBase
    {
        public Movie Movie { get; set; } = new Movie();

        [Inject]
        public IMovieService MovieService{get;set;}

        [Parameter]
        public string Id { get; set; }


        protected async override Task OnInitializedAsync()
        {
            Movie = await MovieService.GetMovie(int.Parse(Id));
        }
    }
}
