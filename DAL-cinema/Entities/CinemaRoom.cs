using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_cinema.Entities
{
    public class CinemaRoom
    {
        public int Id_CinemaRoom { get; set; }
        public int SeatsCount { get; set; }
        public int Number {  get; set; } 
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public bool Can3D { get; set; }

        public bool Can4DX { get; set; }
    }
}
