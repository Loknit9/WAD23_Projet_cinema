using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_cinema.Entities
{
    internal class Movie
    {
        public int Id_Movie { get; set; }

        public string Title { get; set; }

        public string? Subtitle { get; set; }

        public string Release_Year { get; set; }

        public string Synopsis { get; set; }

        public string PosterUrl { get; set; }

        public int Duration { get; set; }
    }
}
