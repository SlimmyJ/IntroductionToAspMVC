using IntroductionToAspMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace IntroductionToAspMVC.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult About()
        {
            string[] skills = new string[] { "C#", "JavaScript", "Sql", "Unity", "Teaching" };

            // One page == One viewmodel.
            // This contains ALL the data that the page needs
            // VM fetches all data, preferably through an injected service
            var model = new UserViewModel
            {
                Users = new List<User>{
                    new User
                    {
                        Id = 1,
                        Name = "Michiel",
                        LastName = "Wouters",
                        DateOfBirth = new DateTime(1900, 1, 1),
                        Skills = skills
                    },
                    new User
                    {
                        Id = 2,
                        Name = "Jos",
                        LastName = "VanHoek",
                        DateOfBirth = new DateTime(1980, 5, 20),
                        Skills = skills
                    },
                    new User
                    {
                        Id = 3,
                        Name = "Jef",
                        LastName = "VanCirkel",
                        DateOfBirth = new DateTime(1998, 2, 12),
                        Skills = skills
                    }
               }
            };

            // ViewBag / Viewdata are outdated processes and bad practices.
            // Prefer (View)Model whenever possible
            //ViewBag.Name = "Michiel in the bag";
            //ViewBag.Skills = skills;

            // VM then passes ViewModel into View
            return View(model);
        }
    }
}