using DAL_cinema.Entities;
using DAL_cinema.Mappers;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_cinema.Services
{
    public class MovieService : BaseService, IMovieRepository<Movie>
    {
        public MovieService (IConfiguration configuration) : base(configuration, "DB-Projet-Cinema")
        {
        }

        public IEnumerable<Movie> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Movie_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToMovie();
                        }
                    }
                }
            }
        }

       
    }
}
