namespace IntroductionToAspMVC.Models
{
    using System;

    using IntroductionToAspMVC.Enums;

    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Rating { get; set; }

        public Genre Genre { get; set; }

        public DateTime Created { get; set; }

        public string Description { get; set; }

        public DateTime Modified { get; set; }
    }
}