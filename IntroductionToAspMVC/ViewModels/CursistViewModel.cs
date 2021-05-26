using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.ViewModels
{
    public class CursistViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<string> Courses { get; set; }

        public int Age { get; set; }

        public int Gender { get; set; }
    }
}
