using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_cinema.Models
{
    public class CinemaPlaceListItemViewModel
    {
        [ScaffoldColumn(false)] 
        public int Id_CinemaPlace { get; set; }

        [DisplayName("Nom")]
        public string Name { get; set; }

        [DisplayName("Ville")]
        public string City { get; set; }

    }
}
