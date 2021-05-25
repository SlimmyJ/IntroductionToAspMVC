using AutoMapper;
using IntroductionToAspMVC.Services;
using IntroductionToAspMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IntroductionToAspMVC.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieService _service;
        private IMapper _mapper;

        public MoviesController(IMovieService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var viewModel = new MovieViewModel
            {
                Movies = _service.GetMovies()
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