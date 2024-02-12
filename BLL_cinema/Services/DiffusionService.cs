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

        public DiffusionService(IDiffusionRepository<DAL.Diffusion> repository)
        {
            _repository = repository;
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

        public IEnumerable<Diffusion> GetByCinemaRoom(int id)
        {
            return _repository.GetByCinemaRoom(id).Select(d => d.ToBLL());
        }
    }
}
