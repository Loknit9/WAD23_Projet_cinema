using DAL_cinema.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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
                SubTitle = (record["SubTitle"] == DBNull.Value) ? null : (string?)record["SubTitle"],
                ReleaseYear = (short)record["ReleaseYear"],
                Synopsis = (string)record["Synopsis"],
                PosterUrl = (string)record["PosterUrl"],
                Duration = (int)record["Duration"]
            };
        }


        public static CinemaRoom ToCinemaRoom(this IDataRecord record)
        {
            if (record is null) return null;
            return new CinemaRoom()
            {
                Id_CinemaRoom = (int)record["Id_CinemaRoom"],
                SeatsCount = (int)record["SeatsCount"],
                Number = (int)record["Number"],
                ScreenWidth = (int)record["ScreenWidth"],
                ScreenHeight = (int)record["ScreenHeight"],
                Can3D = (bool)record["Can3D"],
                Can4DX = (bool)record["Can4DX"]
            };
        }

        public static Diffusion ToDiffusion(this IDataRecord record)
        {
            if (record is null) return null;
            return new Diffusion()
            {
                Id_Diffusion = (int)record["Id_Diffusion"],
                DiffusionDate = (DateOnly)record["DiffusionDate"],
                DiffusionTime = (TimeOnly)record["DiffusionTime"],
                AudioLang = (string)record["AudioLang"],
                SubTitleLang = (record["SubTitleLang"] == DBNull.Value) ? null : (string?)record["SubTitleLang"]
            };
        }
    }
}
