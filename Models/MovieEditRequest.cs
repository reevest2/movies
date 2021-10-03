using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movies.Models
{
    public class MovieEditRequest
    {
        
        //MongoDB has this set to unique
        public string Name { get; set; }

        [Range(0, 10)]
        public int Score { get; set; }

        public string Review { get; set; }

        public bool MustWatch { get; set; }
    }
}
