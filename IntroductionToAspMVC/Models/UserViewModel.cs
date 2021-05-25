using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Models
{
    public class UserViewModel
    {
      public ICollection <User> Users { get; set; }
    }
}
