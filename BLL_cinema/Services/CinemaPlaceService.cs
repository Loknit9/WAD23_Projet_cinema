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
        private readonly ICinemaRoomRepository<DAL.CinemaRoom> _cinemaRoomRepository;
        public CinemaPlaceService(ICinemaPlaceRepository<DAL.CinemaPlace> cinemaPlaceRepository, ICinemaRoomRepository<DAL.CinemaRoom> cinemaRoomRepository)
        {
            _cinemaPlaceRepository = cinemaPlaceRepository;
            _cinemaRoomRepository = cinemaRoomRepository;
        }

        public IEnumerable<CinemaPlace> Get()
        {
            return _cinemaPlaceRepository.Get().Select(d => d.ToBLL());
        }

        public CinemaPlace Get (int id)
        {
            CinemaPlace entity = _cinemaPlaceRepository.Get(id).ToBLL();
            entity.AddGroupCinemaRoom(_cinemaRoomRepository.GetByCinemaPlace(id).Select(d => d.ToBLL()));
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

        public void Delete (int id)
        {
            _cinemaPlaceRepository.Delete(id);
        }

    }
}
