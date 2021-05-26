namespace IntroductionToAspMVC.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class MovieDetailViewModel
    {
        public int Id { get; set; }

        [DefaultValue("Titel")]
        [DisplayName("Titel")]
        [Required(ErrorMessage = "Titel is verplicht.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Omschrijving is verplicht")]
        [MaxLength(
            100,
            ErrorMessage = "Maximum aantal karakters: 100")]
        [DisplayName("Omschrijving")]
        public string Description { get; set; }

        [DefaultValue("01/01/1971")]
        [Required(ErrorMessage = "Datum van release is verplicht")]
        [Range(
            typeof(DateTime),
            "01/01/1970",
            "31/12/9999",
            ErrorMessage = "Film niet ouder zijn dan 1969")]
        [DisplayName("Jaar van release")]
        [DisplayFormat(
            ApplyFormatInEditMode = true,
            DataFormatString = "dd/MM/yyyy")]
        public DateTime? ReleaseDate { get; set; }

        [DefaultValue("A")]
        [Required(ErrorMessage = "Score is verplicht")]
        [DisplayName("Score")]
        [Range(
            1,
            10,
            ErrorMessage = "Geef een score in tussen 1 en 10")]

        public double? Rating { get; set; }

        [Required(ErrorMessage = "Genre is verplicht")]
        [DisplayName("Genre")]
        public int Genre { get; set; }
    }
}