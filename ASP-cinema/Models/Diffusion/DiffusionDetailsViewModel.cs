using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_cinema.Models.Diffusion
{
    public class DiffusionDetailsViewModel
    {
        [HiddenInput]
        [Required]
        public int Id_Diffusion { get; set; }

        [HiddenInput]
        public int Id_Movie { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date)]

        public DateTime DiffusionDate { get; set; }

        [DisplayName("Heure")]
        public TimeSpan DiffusionTime { get; set; }

        [DisplayName("Langue audio")]
        public string AudioLang { get; set; }

        [DisplayName("Sous-titre")]
        public string SubTitleLang {  get; set; }

        [HiddenInput]
        public int Id_CinemaRoom { get; set; }
    }
}
