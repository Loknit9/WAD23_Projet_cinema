using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_cinema.Entities
{
    public class Diffusion
    {
        public int Id_Diffusion { get; set; }
        public DateOnly DiffusionDate { get; set; }
        public TimeOnly DiffusionTime { get; set; }
        public string AudioLang {  get; set; }
        public string? SubTitleLang { get; set; }

    }
}
