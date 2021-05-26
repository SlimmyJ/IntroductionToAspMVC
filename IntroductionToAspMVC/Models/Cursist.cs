using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Models
{
    public class Cursist
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<string> Courses { get; set; }

        public  int Age { get; set; }

        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        X
    }
}
