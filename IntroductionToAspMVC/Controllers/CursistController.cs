using AutoMapper;
using IntroductionToAspMVC.Models;
using IntroductionToAspMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Controllers
{
    public class CursistController : Controller
    {
        private IMapper _mapper;

        public CursistController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CursistViewModel vm)
        {
            Cursist cursist = _mapper.Map<Cursist>(vm);

            // TODO: Data to be sent to service

            return RedirectToAction(nameof(Index));
        }
    }
}
