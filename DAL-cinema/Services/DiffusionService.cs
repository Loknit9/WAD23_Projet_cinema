using DAL_cinema.Entities;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL_cinema.Mappers;

namespace DAL_cinema.Services
{
    public class DiffusionService : BaseService, IDiffusionRepository<Diffusion>
    {


        public DiffusionService(IConfiguration configuration) : base(configuration, "DB-Projet-Cinema")
        {
        }

        public IEnumerable<Diffusion> GetByCinemaPlace(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_GetByCinemaPlace";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_CinemaPlace", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToDiffusion();
                        }
                    }
                }
            }
        }

        public IEnumerable<Diffusion> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString)) 
            { 
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Diffusion_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToDiffusion();
                        }
                    }
                }
            }
        }

        public Diffusion Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_Diffusion_GetById";
                command.CommandType= CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id_Diffusion", id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.ToDiffusion();
                    throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                }
            }
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

        
    }
}
