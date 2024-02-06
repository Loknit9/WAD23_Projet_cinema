using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP_cinema.Models
{
    public class CinemaPlaceEditForm
    {
        [HiddenInput]
        [Required]
        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }

        [DisplayName("Nom")]
        [Required]
        public string Name { get; set; }


        [DisplayName("Ville")]
        [Required(ErrorMessage = "La ville est obligatoire.")]
        [MaxLength(64, ErrorMessage = "La ville ne peut dépasser 64 caractères.")]
        [MinLength(2, ErrorMessage = "La ville doit avoir au minimum 2 caractères.")]
        public string City { get; set; }


        [DisplayName("Rue")]
        [Required(ErrorMessage = "La rue est obligatoire.")]
        [MaxLength(128, ErrorMessage = "La rue ne peut dépasser 128 caractères.")]
        [MinLength(2, ErrorMessage = "La rue doit avoir au minimum 2 caractères.")]
        public string Street { get; set; }


        [DisplayName("Numéro")]
        [Required(ErrorMessage = "Le numéro est obligatoire.")]
        [MaxLength(8, ErrorMessage = "Le numéro ne peut dépasser 8 caractères.")]
        [MinLength(1, ErrorMessage = "Le numéro doit avoir au minimum 1 caractère.")]

        public string Number { get; set; }
    }
}
