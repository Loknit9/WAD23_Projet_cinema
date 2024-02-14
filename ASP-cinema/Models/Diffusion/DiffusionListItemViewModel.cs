using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_cinema.Models.Diffusion
{
    public class DiffusionListItemViewModel
    {
        [HiddenInput]
        [Required]
        [ScaffoldColumn(false)]
        public int Id_Diffusion { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime DiffusionDate { get; set; }

        [DisplayName("Heure")]
        public TimeSpan DiffusionTime { get; set; }

        [DisplayName("Film")]
        [HiddenInput]
        public int Id_Movie { get; set; }

        [DisplayName("Salle")]
        [HiddenInput]
        public int Id_CinemaRoom { get; set; }

        [DisplayName("Film")]

        public string titre {  get; set; }
    }
}
