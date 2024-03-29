﻿using BLL_cinema.Entities;
using BLL_cinema.Mappers;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DAL_cinema.Entities;


namespace BLL_cinema.Services
{
    public class DiffusionService : IDiffusionRepository<Diffusion>
    {

        private readonly IDiffusionRepository<DAL.Diffusion> _diffusionRepository;
        private readonly ICinemaRoomRepository<DAL.CinemaRoom> _cinemaRoomRepository;
        private readonly IMovieRepository<DAL.Movie> _movieRepository;

        public DiffusionService(IDiffusionRepository<DAL.Diffusion> diffusionRepository, ICinemaRoomRepository<DAL.CinemaRoom> cinemaRoomRepository, IMovieRepository<DAL.Movie> movieRepository)
        {
            _diffusionRepository = diffusionRepository;
            _cinemaRoomRepository = cinemaRoomRepository;
            _movieRepository = movieRepository;
        }
        public IEnumerable<Diffusion> Get()
        {
            return _diffusionRepository.Get().Select(d => d.ToBLL());
        }

        public Diffusion Get(int id)
        {
            return _diffusionRepository.Get(id).ToBLL();
        }


        public int Insert(Diffusion data)
        {
            throw new NotImplementedException();
        }

        public void Update(Diffusion data)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Diffusion> GetByCinemaPlace(int id)
        {
            return _diffusionRepository.GetByCinemaPlace(id).Select(d =>
            {
                Diffusion result = d.ToBLL();
                result.CinemaRoom = _cinemaRoomRepository.Get(result.Id_CinemaRoom).ToBLL();
                result.Movie = _movieRepository.Get(result.Id_Movie).ToBLL();
                return result;
            });
        }


        public IEnumerable<Diffusion> GetByMovie(int id)
        {

            return _diffusionRepository.GetByMovie(id).Select(d =>
            {
                Diffusion result = d.ToBLL();
                result.Movie = _movieRepository.Get(result.Id_Movie).ToBLL();
                result.CinemaRoom = _cinemaRoomRepository.Get(result.Id_CinemaRoom).ToBLL();
                return result;
            });
        }
    }
}
