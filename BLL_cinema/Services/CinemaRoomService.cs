using BLL_cinema.Entities;
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
    public class CinemaRoomService : ICinemaRoomRepository<CinemaRoom>
    {
        private readonly ICinemaRoomRepository<DAL.CinemaRoom> _cinemaRoomRepository;
        public CinemaRoomService(ICinemaRoomRepository<DAL.CinemaRoom> cinemaRoomRepository)
        {
            _cinemaRoomRepository = cinemaRoomRepository;
        }

        public IEnumerable<CinemaRoom> Get()
        {
            return _cinemaRoomRepository.Get().Select(d => d.ToBLL());
        }

        public CinemaRoom Get(int id)
        {
            
            return _cinemaRoomRepository.Get(id).ToBLL();
        }

        public int Insert(CinemaRoom data)
        {
            return _cinemaRoomRepository.Insert(data.ToDAL());
        }
        public void Update(CinemaRoom data)
        {
            _cinemaRoomRepository.Update(data.ToDAL());
        }
        public void Delete(int id)
        {
            _cinemaRoomRepository.Delete(id);
        }

        public IEnumerable<CinemaRoom> GetByCinema(int id_cinemaRoom)
        {
            return _cinemaRoomRepository.GetByCinema(id_cinemaRoom).Select(d => d.ToBLL());
        }
    }
}
