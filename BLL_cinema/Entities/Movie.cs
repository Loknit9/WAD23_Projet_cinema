using DAL_cinema.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_cinema.Entities
{
    public class Movie
    {

        private List<Diffusion> _diffusions;


        public int Id_Movie { get;  private set; }
        public string Title { get;  private set; }
        public string? SubTitle { get; private set; }
        public short ReleaseYear { get;  private set; }
        public string Synopsis { get;  private set; }
        public string PosterUrl { get;  private set; }
        public int Duration { get;  private set; }

        public Diffusion[] Diffusions
        {
            get
            {
                return _diffusions?.ToArray() ?? new Diffusion[0];
            }
        }


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


        public void AddDiffusion(Diffusion diffusion)
        {
            _diffusions ??= new List<Diffusion>();
            if (diffusion is null) throw new ArgumentNullException(nameof(diffusion));
            if (_diffusions.Contains(diffusion)) throw new ArgumentException(nameof(diffusion), $"la diffusion {diffusion.Id_Diffusion} est déjà dans la liste.");
            _diffusions.Add(diffusion);
        }


        public void AddGroupDiffusions(IEnumerable<Diffusion> diffusions)
        {
            if (diffusions is null) throw new ArgumentNullException(nameof(diffusions));
            foreach (Diffusion diffusion in diffusions)
            {
                AddDiffusion(diffusion);
            }
        }
        

    }


}
