using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DAL_cinema.Entities;
using BLL_cinema.Entities;
using BLL_cinema.Mappers;

namespace BLL_cinema.Services
{
    public class MovieService : IMovieRepository<Movie>
    {
        private readonly IMovieRepository<DAL.Movie> _repository;

        public MovieService(IMovieRepository<DAL.Movie> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Movie> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public Movie Get (int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert (Movie data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public void Update(Movie data)
        {
            _repository.Update(data.ToDAL());
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

    }
}
