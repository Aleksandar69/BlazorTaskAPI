using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApiApp.Models
{
    public class Movie
    {
        private bool adult { get; set; }
        private string backdrop_path { get; set; }
        private Collection belongs_to_collection { get; set; }
        private int budget { get; set; }
        private List<Genres> genres { get; set; }
        private string homepage { get; set; }
        private int id { get; set; }
        private string imdb_id { get; set; }
        private string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        private double popularity { get; set; }
        private string poster_path { get; set; }
        private List<ProductionCompany> production_companies { get; set; }

        private List<ProductionCompany> production_countries { get; set; }

        private string release_date { get; set; }
        private double revenue { get; set; }
        private int runtime { get; set; }
        private List<SpokenLanguages> spoken_languages { get; set; }

        private string status { get; set; }
        private string tagline { get; set; }

        private string title { get; set; }
        private bool video { get; set; }
        private double vote_average { get; set; }
        private double vote_count { get; set; }



    }
}
