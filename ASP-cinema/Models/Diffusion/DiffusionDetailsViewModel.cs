using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_cinema.Models.Diffusion
{
    public class DiffusionDetailsViewModel
    {
        [ScaffoldColumn(false)]
        [Required]
        public int Id_Diffusion { get; set; }

        [DisplayName("Date")]
        public DateOnly DiffusionDate { get; set; }

        [DisplayName("Heure")]
        public TimeOnly DiffusionTime { get; set; }

        [DisplayName("Langue audio")]
        public string AudioLang { get; set; }

        [DisplayName("Sous-titre")]
        public string SubTitleLang {  get; set; }
    }
}
