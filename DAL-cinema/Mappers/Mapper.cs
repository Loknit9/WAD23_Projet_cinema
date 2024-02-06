using DAL_cinema.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_cinema.Mappers
{
    internal static class Mapper
    {
        public static CinemaPlace ToCinemaPlace(this IDataRecord record)
        {
            if (record is null) return null;
            return new CinemaPlace()
            {
                Id_CinemaPlace = (int)record["Id_CinemaPlace"],
                Name = (string)record["Name"],
                City = (string)record["City"],
                Street = (string)record["Street"],
                Number = (string)record["Number"]
            };
        }
    


    public static Movie ToMovie(this IDataRecord record)
        {
            if (record is null) return null;
            return new Movie()
            {
                Id_Movie = (int)record["Id_Movie"],
                Title = (string)record["Title"],
                SubTitle = (string)record["Subtitle"],
                Release_Year = (string)record["Release_Year"],
                Synopsis = (string)record["Synopsis"],
                PosterUrl = (string)record["PosterUrl"],
                Duration = (int)record["Duration"]
            };
        }
    }
}
