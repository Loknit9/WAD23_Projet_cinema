using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_cinema.Models.CinemaPlace
{
    public class CinemaPlaceChoiceCinemaRoomForm
    {
        [HiddenInput]
        [Required]
        public int Id_CinemaPlace {  get; set; }

        [Required]
        [DisplayName("Veuillez choisir une salle:")]
        public int Id_CinemaRoom { get; set; }

    }
}
