using AutoMapper;
using IntroductionToAspMVC.Models;
using IntroductionToAspMVC.ViewModels;

namespace IntroductionToAspMVC.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, MovieDetailViewModel>()
                .ReverseMap();
        }
    }
}