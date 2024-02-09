using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_cinema.Entities
{
    public class Diffusion
    {
        public int Id_Diffusion { get; private set; }
        public DateTime DiffusionDate { get; private set; }

        public TimeSpan DiffusionTime { get; private set; }

        public string AudioLang { get; private set; }

        public string? SubTitleLang { get; private set; }

        public int Id_Movie {  get; private set; }

        public int Id_CinemaRoom { get; private set; }


        public Diffusion(int id_diffusion, DateTime diffusiondate, TimeSpan diffusiontime, string audioLang, string? subtitlelang, int id_Movie, int id_CinemaRoom)
        {
            Id_Diffusion = id_diffusion;
            DiffusionDate = diffusiondate;
            DiffusionTime = diffusiontime;
            AudioLang = audioLang;
            SubTitleLang = subtitlelang;
            Id_Movie = id_Movie;
            Id_CinemaRoom = id_CinemaRoom;
        }
    } 
}
