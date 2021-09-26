using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApiApp.Models
{
    public class MovieQuery
    {
        private bool adult { get; set; }
        private string backdrop_path { get; set; }
        private int[] genre_ids { get; set; }
        public int id { get; set; }
        private string original_language { get; set; }
        private string original_title { get; set; }
        public string overview { get; set; }
        private double popularity { get; set; }
        private string poster_path { get; set; }
        private string release_date { get; set; }
        public string title { get; set; }
        private bool video { get; set; }
        private double vote_average { get; set; }
        private int vote_count { get; set; }



    }
}
