using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_cinema.Entities
{
    public class Movie
    {
        public int Id_Movie { get;  set; }
        public string Title { get;  set; }
        public string? SubTitle { get; set; }
        public short Release_Year { get;  set; }
        public string Synopsis { get;  set; }
        public string PosterUrl { get;  set; }
        public int Duration { get;  set; }


        public Movie(int id_movie, string title, string? subtitle, short release_year, string synopsis, string posterurl, int duration)
        {
            Id_Movie = id_movie;
            Title = title;
            SubTitle = subtitle;
            Release_Year = release_year;
            Synopsis = synopsis;
            PosterUrl = posterurl;
            Duration = duration;

        }
    }
}
