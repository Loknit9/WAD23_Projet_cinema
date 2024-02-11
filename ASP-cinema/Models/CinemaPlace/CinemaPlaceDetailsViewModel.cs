using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using ASP_cinema.Models.CinemaRoom;

namespace ASP_cinema.Models.CinemaPlace
{
    public class CinemaPlaceDetailsViewModel
    {
        [HiddenInput]
        [Required]
        public int Id_CinemaPlace { get; set; }

        [DisplayName("Nom")]
        public string Name { get; set; }

        [DisplayName("Ville")]
        public string City { get; set; }

        [DisplayName("Rue")]
        public string Street { get; set; }

        [DisplayName("Numero")]
        public string Number { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Salles")]
        public IEnumerable<CinemaRoomListItemViewModel> CinemaRooms { get; set; }
    }
}
