namespace IntroductionToAspMVC.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using IntroductionToAspMVC.Models;
    using IntroductionToAspMVC.Services;
    using IntroductionToAspMVC.ViewModels;

    using Microsoft.AspNetCore.Mvc;

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
                                Movies = _mapper.Map<ICollection<Movie>>(movies)
                            };

            return View(viewModel);
        }

        public IActionResult Detail(int id)
        {
            Movie movie = _service.GetMovies()
                                  .FirstOrDefault(x => x.Id == id);
            MovieDetailViewModel viewModel = _mapper.Map<MovieDetailViewModel>(movie);

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(MovieDetailViewModel vm)
        {
            // Verify if all data annotations check in ViewModel are valid
            bool isValid = TryValidateModel(vm);

            if (isValid)
            {
                Movie movie = _mapper.Map<Movie>(vm);
                return RedirectToAction(nameof(Index));
            }

            // Show view again with errors if model is not valid
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}