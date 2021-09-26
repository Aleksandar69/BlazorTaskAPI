using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApiApp.Models
{
    public class Collection
    {
        private int Id { get; set; }
        private string name { get; set; }
        private string poster_path { get; set; }
        private string backdrop_path { get; set; }
    }
}
