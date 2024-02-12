using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_cinema.Entities
{
    public class CinemaRoom
    {
        public int Id_CinemaRoom { get; private set; }
        public int SeatsCount { get; private set; }
        public int Number {  get; private set; }
        public int ScreenWidth { get; private set; }
        public int ScreenHeight { get; private set;}
        public bool Can3D { get; private set; }
        public bool Can4DX { get; private set;}

        public int Id_CinemaPlace { get; private set; }
        public CinemaPlace CinemaPlace { get; private set; }

       

        public CinemaRoom(int id_cinemaroom, int seatscount, int number, int screenwidth, int screenheight, bool can3d, bool can4DX, int id_cinemaplace)
        {
            Id_CinemaRoom = id_cinemaroom;
            SeatsCount = seatscount;
            Number = number;
            ScreenWidth = screenwidth;
            ScreenHeight = screenheight;
            Can3D = can3d;
            Can4DX = can4DX;
            Id_CinemaPlace = id_cinemaplace;
        }

       
    }
}
