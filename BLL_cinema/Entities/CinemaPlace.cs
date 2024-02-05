using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_cinema.Entities
{
    public class CinemaPlace
    {
        public int Id_CinemaPlace { get; private set; }
        public string Name { get; private set;}

        public string City { get; private set; }

        public string Street { get; private set; }

        public string Number { get; private set; }


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
