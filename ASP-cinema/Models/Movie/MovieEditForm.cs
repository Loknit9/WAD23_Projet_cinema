using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP_cinema.Models.Movie
{
    public class MovieEditForm
    {
        [HiddenInput]
        [Required]
        public int Id_Movie { get; set; }

        [DisplayName("Titre")]
        [Required(ErrorMessage = "Le titre est obligatoire.")]
        [MaxLength(64, ErrorMessage = "Le titre ne peut dépasser 64 caractères.")]
        [MinLength(2, ErrorMessage = "Le titre doit avoir au minimum 2 caractères.")]
        public string Title { get; set; }

        [DisplayName("Sous-titre")]
        [MaxLength(64, ErrorMessage = "Le soustitre ne peut dépasser 64 caractères.")]
        [MinLength(2, ErrorMessage = "Le soustitre doit avoir au minimum 2 caractères.")]
        public string? SubTitle { get; set; }

        [DisplayName("Année de sortie")]
        [Required(ErrorMessage = "L'année de sortie est obligatoire.")]

        [Range(1800, int.MaxValue, ErrorMessage = "L'année de sortie doit être comprise entre 1800 et l'année en cours")]
        public short ReleaseYear { get; set; }

        [DisplayName("Résumé")]
        [Required(ErrorMessage = "Le résumé est obligatoire.")]
        [MinLength(180, ErrorMessage = "Le résumé doit avoir au minimum 180 caractères.")]
        public string Synopsis { get; set; }

        [DisplayName("Durée")]
        [Required(ErrorMessage = "La durée est obligatoire.")]
        [Range(10, 420, ErrorMessage = "La durée doit être comprise entre 10 et 420 minutes")]
        public int Duration { get; set; }

        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Le poster est obligatoire.")]
        public string PosterUrl { get; set; }
    }
}
