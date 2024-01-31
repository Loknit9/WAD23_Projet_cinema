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
    public class CinemaPlaceService : BaseService, ICinemaPlaceRepository<CinemaPlace>
    {
        public CinemaPlaceService(IConfiguration configuration) : base(configuration, "DB-Projet-Cinema")
        {
        }

        public IEnumerable<CinemaPlace> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_CinemaPlace_GetAll";
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader.ToCinemaPlace();
                    }
                }
            }
        }


        public CinemaPlace Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_CinemaPlaceGetById";
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.ToCinemaPlace();
                    throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                }
            }
        }
    }
}
