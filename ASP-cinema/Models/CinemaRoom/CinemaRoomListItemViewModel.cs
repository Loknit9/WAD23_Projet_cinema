﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_cinema.Models.CinemaRoom
{
    public class CinemaRoomListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_CinemaRoom { get; set; }

        [DisplayName("Numéro de Salle")]
        public int Number { get; set; }

        [DisplayName("Projection 3D")]
        public bool Can3D { get; set; }

        [DisplayName("Projection 4DX")]
        public bool Can4DX { get; set; }

    }
}