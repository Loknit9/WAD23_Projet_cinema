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
        public DateTime DiffusionDate { get; set; }

        [DisplayName("Heure")]
        public TimeSpan DiffusionTime { get; set; }

    }
}
