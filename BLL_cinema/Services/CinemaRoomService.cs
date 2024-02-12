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
        private readonly IDiffusionRepository<DAL.Diffusion> _diffusionRepository;
        public CinemaRoomService(ICinemaRoomRepository<DAL.CinemaRoom> cinemaRoomRepository, IDiffusionRepository<DAL.Diffusion> diffusionRepository)
        {
            _cinemaRoomRepository = cinemaRoomRepository;
            _diffusionRepository = diffusionRepository;
        }

        public IEnumerable<CinemaRoom> Get()
        {
            return _cinemaRoomRepository.Get().Select(d => d.ToBLL());
        }

        public CinemaRoom Get(int id)
        {
            CinemaRoom entity = _cinemaRoomRepository.Get(id).ToBLL();
            entity.AddGroupDiffusions(_diffusionRepository.GetByCinemaRoom(id).Select(d => d.ToBLL()));
            return entity;
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

        public IEnumerable<CinemaRoom> GetByCinemaPlace (int id)
        {
            return _cinemaRoomRepository.GetByCinemaPlace(id).Select(d => d.ToBLL());
        }
    }
}
