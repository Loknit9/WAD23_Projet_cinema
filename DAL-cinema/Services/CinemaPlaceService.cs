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
                using (SqlCommand command = connection.CreateCommand())
                {
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
        }


        public CinemaPlace Get(int Id_cinemaplace)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_CinemaPlace_GetById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", Id_cinemaplace);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.ToCinemaPlace();
                    throw new ArgumentException(nameof(Id_cinemaplace), $"L'identifiant {Id_cinemaplace} n'existe pas dans la base de données.");
                }
            }
        }

        public int Insert(CinemaPlace data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_CinemaPlace_Insert";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Name", data.Name);
                command.Parameters.AddWithValue("City", data.City);
                command.Parameters.AddWithValue("Street", data.Street);
                command.Parameters.AddWithValue("Number", data.Number);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public void Update(CinemaPlace data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_CinemaPlace_Update";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", data.Id_CinemaPlace);
                command.Parameters.AddWithValue("Name", data.Name);
                command.Parameters.AddWithValue("City", data.City);
                command.Parameters.AddWithValue("Street", data.Street);
                command.Parameters.AddWithValue("Number", data.Number);
                connection.Open();
                if (command.ExecuteNonQuery() <= 0)
                    throw new ArgumentException(nameof(data.Id_CinemaPlace), $"L'identifiant {data.Id_CinemaPlace} n'est pas das la base de données");
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_CinemaPlace_Delete";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                if (command.ExecuteNonQuery() <= 0)
                    throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
            }
        }
    }
}
