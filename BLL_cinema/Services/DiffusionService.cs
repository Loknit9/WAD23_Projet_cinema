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
    public class DiffusionService : IDiffusionRepository<Diffusion>
    {

        private readonly IDiffusionRepository<DAL.Diffusion> _repository;
        private readonly ICinemaRoomRepository<DAL.CinemaRoom> _cinemaRoomRepository;

        public DiffusionService(IDiffusionRepository<DAL.Diffusion> repository, ICinemaRoomRepository<DAL.CinemaRoom> cinemaRoomRepository)
        {
            _repository = repository;
            _cinemaRoomRepository = cinemaRoomRepository;
        }
        public IEnumerable<Diffusion> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public Diffusion Get(int id)
        {
            return _repository.Get(id).ToBLL();
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
            return _repository.GetByCinemaPlace(id).Select(d =>
            {
                Diffusion result = d.ToBLL();
                result.CinemaRoom = _cinemaRoomRepository.Get(result.Id_CinemaRoom).ToBLL();
                return result;
            });
        }


        IEnumerable<Diffusion> IDiffusionRepository<Diffusion>.GetByMovie(int id_movie)
        {
            throw new NotImplementedException();
        }
    }
}
