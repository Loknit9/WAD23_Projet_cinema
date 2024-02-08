using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP_cinema.Models.CinemaRoom
{
    public class CinemaRoomDetailsViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_CinemaRoom { get; set; }

        [DisplayName("Nombre de siège")]
        public int SeatsCount { get; set; }

        [DisplayName("Largeur écran")]
        public int ScreenWidth { get; set; }

        [DisplayName("Hauteur écran")]
        public int ScreenHeight { get; set; }

        [DisplayName("Numéro de Salle")]
        public int Number { get; set; }

        [DisplayName("Projection 3D")]
        public bool Can3D { get; set; }

        [DisplayName("Projection 4DX")]
        public bool Can4DX { get; set; }
    }
}
