﻿using DAL_cinema.Entities;
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
        private List<Diffusion> _diffusions;
        private List<Movie> _movies;



        public int Id_CinemaPlace { get; private set; }
        public string Name { get; private set; }

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



        public Movie[] Movie
        {
            get
            {
                return _movies?.ToArray() ?? new Movie[0];
            }
        }

        public Diffusion[] Diffusions
        {
            get
            {
                return _diffusions?.ToArray() ?? new Diffusion[0];
            }
        }


        public CinemaPlace(int id_cinemaplace, string name, string city, string street, string number)
        {
            Id_CinemaPlace = id_cinemaplace;
            Name = name;
            City = city;
            Street = street;
            Number = number;
        }

        public CinemaPlace(List<Diffusion> diffusions, List<CinemaRoom> cinemaRooms, List<Movie> movies, int id_CinemaPlace, string name, string city, string street, string number)
        {
            _diffusions = diffusions;
            _cinemarooms = cinemaRooms;
            Id_CinemaPlace = id_CinemaPlace;
            Name = name;
            City = city;
            Street = street;
            Number = number;
        }


        public void AddCinemaRoom(CinemaRoom cinemaroom)
        {
            _cinemarooms ??= new List<CinemaRoom>();
            //if(cinemaroom is null) throw new ArgumentNullException(nameof(cinemaroom));
            //if (_cinemarooms.Contains(cinemaroom)) throw new ArgumentException(nameof(cinemaroom), $"Cette salle {cinemaroom.Id_CinemaRoom} est déjà reprise pour ce cinema.");
            //if ((!(cinemaroom.CinemaPlace is null) && cinemaroom.CinemaPlace != this) || cinemaroom.Id_CinemaPlace != this.Id_CinemaPlace) throw new ArgumentException(nameof(cinemaroom), $"la salle {cinemaroom.Id_CinemaRoom} est déjà reprise un autre cinéma.");
            _cinemarooms.Add(cinemaroom);
        }


        public void AddGroupCinemaRoom(IEnumerable<CinemaRoom> cinemarooms)
        {
            if (cinemarooms is null) throw new ArgumentNullException(nameof(cinemarooms));
            {
                foreach (CinemaRoom room in cinemarooms)
                {
                    AddCinemaRoom(room);
                }
            }
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

        //public void AddMovie(Movie movie)
        //{
        //    _movies ??= new List<Movie>();
        //    if (movie is null) throw new ArgumentNullException(nameof(movie));
        //    if (_movies.Contains(movie)) throw new ArgumentException(nameof(movie), $"la diffusion {movie.Id_Movie} est déjà dans la liste.");
        //    _movies.Add(movie);
        //}

        //public void AddGroupMovies(IEnumerable<Movie> movies)
        //{
        //    if (movies is null) throw new ArgumentNullException(nameof(movies));
        //    foreach (Movie movie in movies)
        //    {
        //        AddMovie(movie);

        //    }

        //}
    }
}
