using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Rating { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
