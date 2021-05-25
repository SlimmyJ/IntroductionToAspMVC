using System;

namespace IntroductionToAspMVC.ViewModels
{
    public class MovieDetailViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Rating { get; set; }
    }
}