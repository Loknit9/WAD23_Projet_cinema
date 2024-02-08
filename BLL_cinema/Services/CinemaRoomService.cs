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
    public class CinemaRoomService: ICinemaRoomRepository<CinemaRoom>
    {
        private readonly ICinemaRoomRepository<DAL.CinemaRoom> _repository;
        public CinemaRoomService(ICinemaRoomRepository<DAL.CinemaRoom> repository)
        {
            _repository = repository;
        }

        public IEnumerable<CinemaRoom> Get() 
        {
            return _repository.Get().Select(d =>d.ToBLL());
        }

        public CinemaRoom Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }
    }

        
    }
}
