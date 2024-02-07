using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_cinema.Models
{
    public class MovieDeleteViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Movie { get; set; }

        [DisplayName("Titre")]
        public string Title { get; set; }

        [DisplayName("Sous-titre")]
        public string? SubTitle { get; set; }

        [DisplayName("Année de sortie")]
        public short ReleaseYear { get; set; }

        [DisplayName("Résumé")]
        public string Synopsis { get; set; }

        [DisplayName("Durée")]
        public int Duration { get; set; }

        [DataType(DataType.ImageUrl)]
        public string PosterUrl { get; set; }
    }
}
