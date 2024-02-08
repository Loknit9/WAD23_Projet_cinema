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
        public DateOnly DiffusionDate { get; private set; }

        public TimeOnly DiffusionTime { get; private set; }

        public string AudioLang { get; private set; }

        public string? SubTitleLang { get; private set; }


        public Diffusion(int id_diffusion, DateOnly diffusiondate, TimeOnly diffusiontime, string audioLang, string? subtitlelang)
        {
            Id_Diffusion = id_diffusion;
            DiffusionDate = diffusiondate;
            DiffusionTime = diffusiontime;
            AudioLang = audioLang;
            SubTitleLang = subtitlelang;
        }
    } 
}
