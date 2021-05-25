using System.Collections.Generic;
using AutoMapper;
using IntroductionToAspMVC.Services;
using IntroductionToAspMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using IntroductionToAspMVC.Dto;
using IntroductionToAspMVC.Models;

namespace IntroductionToAspMVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _service;
        private readonly IMapper _mapper;

        public MoviesController(IMovieService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            ICollection<Movie> movies = _service.GetMovies();
            var viewModel = new MovieViewModel
            {
                Movies = _mapper.Map<ICollection<MovieDto>>(movies)
            };

            return View(viewModel);
        }

        public IActionResult Detail(int id)
        {
            Models.Movie movie = _service.GetMovies().FirstOrDefault(x => x.Id == id);
            MovieDetailViewModel viewModel = _mapper.Map<MovieDetailViewModel>(movie);

            return View(viewModel);
        }
    }
}