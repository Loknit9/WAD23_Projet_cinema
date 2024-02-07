using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_cinema.Entities
{
    public class Movie
    {
        public int Id_Movie { get;  private set; }
        public string Title { get;  private set; }
        public string? SubTitle { get; private set; }
        public short ReleaseYear { get;  private set; }
        public string Synopsis { get;  private set; }
        public string PosterUrl { get;  private set; }
        public int Duration { get;  private set; }


        public Movie(int id_movie, string title, string? subtitle, short releaseyear, string synopsis, string posterurl, int duration)
        {
            Id_Movie = id_movie;
            Title = title;
            SubTitle = subtitle;
            ReleaseYear = releaseyear;
            Synopsis = synopsis;
            PosterUrl = posterurl;
            Duration = duration;

        }
    }
}
