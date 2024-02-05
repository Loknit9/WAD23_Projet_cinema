using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_cinema.Models
{
    public class CinemaPlaceDeleteViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }

        [DisplayName("Nom")]
        public string Name { get; set; }

        [DisplayName("Ville")]
        public string City { get; set; }

        [DisplayName("Rue")]
        public string Street { get; set; }

        [DisplayName("Numero")]
        public string Number { get; set; }
    }
}
