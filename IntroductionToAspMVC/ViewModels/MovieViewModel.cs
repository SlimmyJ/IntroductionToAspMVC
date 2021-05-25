using IntroductionToAspMVC.Dto;
using System.Collections.Generic;

namespace IntroductionToAspMVC.ViewModels
{
    public class MovieViewModel
    {
        public ICollection<MovieDto> Movies { get; set; }
    }
}