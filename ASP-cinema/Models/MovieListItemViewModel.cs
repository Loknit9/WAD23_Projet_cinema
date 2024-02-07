using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_cinema.Models
{
    public class MovieListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Movie { get; set; }

        [DisplayName("Titre")]
        public string Title { get; set; }

        [DisplayName("Durée")]
        public int Duration { get; set; }

        //[DataType(DataType.ImageUrl)]
        public string PosterUrl { get; set; }

    }
}
