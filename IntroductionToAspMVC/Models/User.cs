using System;

namespace IntroductionToAspMVC.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string[] Skills { get; set; }
    }
}