using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movies.Models
{
    public class Movie
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public int Score { get; set; }
        public string Review { get; set; }

        public bool MustWatch { get; set; }
    }
}
