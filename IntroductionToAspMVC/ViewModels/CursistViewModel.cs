namespace IntroductionToAspMVC.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class CursistViewModel
    {
        public int Id { get; set; }

        [DisplayName("Voornaam")]
        [Required(ErrorMessage = "Voornaam is verplicht")]
        [MinLength(
            3,
            ErrorMessage = "Tenminste 3 karakters")]
        [MaxLength(
            20,
            ErrorMessage = "Tenminste 20 karakters")]
        public string FirstName { get; set; }

        [DisplayName("Achternaam")]
        [Required(ErrorMessage = "Achternaam is verplicht")]
        public string LastName { get; set; }

        public ICollection<string> Courses { get; set; }

        [DisplayName("Leeftijd")]
        [Range(
            12,
            18,
            ErrorMessage = "Moet tussen 12 en 18 liggen.")]
        public int Age { get; set; }

        [DisplayName("Datum van geboorte")]
        [Range(
            typeof(DateTime),
            "01/01/1970",
            "01/01/2003")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Geslacht")]
        public int Gender { get; set; }
    }
}