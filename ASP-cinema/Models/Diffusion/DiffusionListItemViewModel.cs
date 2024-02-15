using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_cinema.Models.Diffusion
{
    public class DiffusionListItemViewModel
    {
        [HiddenInput]
        [Required]
        [ScaffoldColumn(false)]
        public int Id_Diffusion { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime DiffusionDate { get; set; }

        [DisplayName("Heure")]

        public TimeSpan DiffusionTime { get; set; }

        [DisplayName("Salle")]
        public int NumeroSalle { get; set; }

        [HiddenInput]
        [ScaffoldColumn(false)]

        public int Id_CinemaRoom { get; set; }

        
        [HiddenInput]
        public int Id_Movie { get; set; }

        [DisplayName("Film")]
        public string titre {  get; set; }

        [DisplayName("Durée")]
        public int Duree { get; set; }

        [DisplayName("3D")]
        public bool Can3D { get; set; }

        [DisplayName("4DX")]
        public bool Can4DX { get; set; }

        [DisplayName("Audio")]
        public string? Audiolang {  get; set; }

        [DisplayName("Sous-Titre")]
        public string SubTitle { get; set; }


    }
}