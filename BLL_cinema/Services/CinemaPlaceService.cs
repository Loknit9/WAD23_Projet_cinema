using Shared.Repositories;
using DAL = DAL_cinema.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_cinema.Entities;
using BLL_cinema.Mappers;
namespace BLL_cinema.Services
{
    public class CinemaPlaceService : ICinemaPlaceRepository<CinemaPlace>
    {
        private readonly ICinemaPlaceRepository<DAL.CinemaPlace> _cinemaPlaceRepository;
        private readonly ICinemaRoomRepository<CinemaRoom> _cinemaRoomRepository;
        private readonly IDiffusionRepository<Diffusion> _diffusionRepository;
        public CinemaPlaceService(ICinemaPlaceRepository<DAL.CinemaPlace> cinemaPlaceRepository, ICinemaRoomRepository<CinemaRoom> cinemaRoomRepository, IDiffusionRepository<Diffusion> diffusionRepository, IMovieRepository<DAL.Movie> movieRepository)
        {
            _cinemaPlaceRepository = cinemaPlaceRepository;
            _cinemaRoomRepository = cinemaRoomRepository;
            _diffusionRepository = diffusionRepository;
        }

        public IEnumerable<CinemaPlace> Get()
        {
            return _cinemaPlaceRepository.Get().Select(d => d.ToBLL());
        }

        public CinemaPlace Get(int id)
        {

            CinemaPlace entity = _cinemaPlaceRepository.Get(id).ToBLL();
            entity.AddGroupDiffusions(_diffusionRepository.GetByCinemaPlace(id));
            entity.AddGroupCinemaRoom(_cinemaRoomRepository.GetByCinema(id));



            return entity;
        }

        public int Insert(CinemaPlace data)
        {
            return _cinemaPlaceRepository.Insert(data.ToDAL());
        }

        public void Update(CinemaPlace data)
        {
            _cinemaPlaceRepository.Update(data.ToDAL());
        }

        public void Delete(int id)
        {
            _cinemaPlaceRepository.Delete(id);
        }

    }
}
