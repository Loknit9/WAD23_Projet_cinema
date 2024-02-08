using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_cinema.Models.Diffusion
{
    public class DiffusionListItemViewModel
    {
        [ScaffoldColumn(false)]
        [Required]
        public int Id_Diffusion { get; set; }

        [DisplayName("Date")]
        public DateOnly DiffusionDate { get; set; }

        [DisplayName("Heure")]
        public TimeOnly DiffusionTime { get; set; }

    }
}
