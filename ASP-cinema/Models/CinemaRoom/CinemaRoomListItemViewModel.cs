using ASP_cinema.Models.Diffusion;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_cinema.Models.CinemaRoom
{
    public class CinemaRoomListItemViewModel
    {
        [HiddenInput]
        [Required]
        [ScaffoldColumn(false)]

        public int Id_CinemaRoom { get; set; }

        [DisplayName("Salle")]
        public int Number { get; set; }

        [DisplayName("Projection 3D")]
        public bool Can3D { get; set; }

        [DisplayName("Projection 4DX")]
        public bool Can4DX { get; set; }

    }
}
