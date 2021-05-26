using IntroductionToAspMVC.Enums;
using System.Collections.Generic;

namespace IntroductionToAspMVC.Models
{
    public class Cursist
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<string> Courses { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }
    }
}