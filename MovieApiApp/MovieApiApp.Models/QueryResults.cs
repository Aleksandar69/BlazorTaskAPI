using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApiApp.Models
{
    public class QueryResults
    {
        private int page { get; set; }
        public List<MovieQuery> results { get; set; }
        private int total_pages { get; set; }
        private int total_results { get; set; }
    }
}
