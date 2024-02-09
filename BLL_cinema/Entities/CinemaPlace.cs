using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_cinema.Entities
{
    public class CinemaPlace
    {
        private List<Diffusion> _diffusions;
        public int Id_CinemaPlace { get; private set; }
        public string Name { get; private set;}

        public string City { get; private set; }

        public string Street { get; private set; }

        public string Number { get; private set; }

        //  liste des diffusions par cinema
        public Diffusion[] Diffusions
        {
            get
            {
                return _diffusions.ToArray() ?? new Diffusion[0];
            }
        }


        public CinemaPlace (int id_cinemaplace, string name, string city, string street, string number)
        {
            Id_CinemaPlace = id_cinemaplace;
            Name = name;
            City = city;
            Street = street;
            Number = number;
        }

    }

}
