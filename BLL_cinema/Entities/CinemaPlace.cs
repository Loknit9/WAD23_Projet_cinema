using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_cinema.Entities
{
    public class CinemaPlace
    {
        private List<CinemaRoom> _cinemarooms;

        public int Id_CinemaPlace { get; private set; }
        public string Name { get; private set;}

        public string City { get; private set; }

        public string Street { get; private set; }

        public string Number { get; private set; }

        //  liste des diffusions par cinema
        public CinemaRoom[] CinemaRooms
        {
            get
            {
                return _cinemarooms?.ToArray() ?? new CinemaRoom[0];
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

        public void AddCinemaRoom (CinemaRoom cinemaroom)
        {
            _cinemarooms ??= new List<CinemaRoom> ();
            if(cinemaroom is null) throw new ArgumentNullException(nameof(cinemaroom));
            if (_cinemarooms.Contains(cinemaroom)) throw new ArgumentException(nameof(cinemaroom), $"Cette salle {cinemaroom.Id_CinemaRoom} est déjà reprise pour ce cinema.");
            if ((!(cinemaroom.CinemaPlace is null) && cinemaroom.CinemaPlace != this) || cinemaroom.Id_CinemaPlace != this.Id_CinemaPlace) throw new ArgumentException(nameof(cinemaroom), $"la salle {cinemaroom.Id_CinemaRoom} est déjà reprise un autre cinéma.");
            _cinemarooms.Add(cinemaroom);
        }

        public void AddGroupCinemaRoom(IEnumerable<CinemaRoom> cinemarooms)
        {
            if (cinemarooms is null) throw new ArgumentNullException(nameof(cinemarooms));
            {
                foreach(CinemaRoom room in cinemarooms)
                {
                    AddCinemaRoom(room);
                }
            }
        }

    }

}
