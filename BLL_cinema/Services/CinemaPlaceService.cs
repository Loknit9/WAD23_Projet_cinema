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
        private readonly ICinemaPlaceRepository<DAL.CinemaPlace> _repository;
        public CinemaPlaceService(ICinemaPlaceRepository<DAL.CinemaPlace> repository)
        {
            _repository = repository;
        }

        public IEnumerable<CinemaPlace> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public CinemaPlace Get (int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(CinemaPlace data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public void Update(CinemaPlace data)
        {
            _repository.Update(data.ToDAL());
        }

        public void Delete (int id)
        {
            _repository.Delete(id);
        }

    }
}
