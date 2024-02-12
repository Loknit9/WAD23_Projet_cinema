using BLL_cinema.Entities;
using System.Runtime.CompilerServices;
using System.Reflection;
using ASP_cinema.Models.CinemaPlace;
using ASP_cinema.Models.Movie;
using ASP_cinema.Models.CinemaRoom;
using ASP_cinema.Models.Diffusion;

namespace ASP_cinema.Handlers
{
    public static class Mapper
    {
        #region CinemaPlace
        public static CinemaPlaceListItemViewModel ToListItem(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceListItemViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
            };
        }

        public static CinemaPlaceDetailsViewModel ToDetails(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceDetailsViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number,
                CinemaRooms = entity.CinemaRooms.Select(d => d.ToListItem()),
                Diffusions = entity.Diffusions.Select(d => d.ToListItem())
            };
        }

        public static CinemaPlace ToBLL(this CinemaPlaceCreateForm entity)
        {
            if (entity is null) return null;
            return new CinemaPlace(
                0,
                entity.Name,
                entity.City,
                entity.Street,
                entity.Number
                );
        }

        public static CinemaPlaceEditForm Update(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceEditForm()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number
            };
        }

        public static CinemaPlace ToBLL(this CinemaPlaceEditForm entity)
        {
            if (entity is null) return null;
            return new CinemaPlace(
                entity.Id_CinemaPlace,
                entity.Name,
                entity.City,
                entity.Street,
                entity.Number
            );
        }

        public static CinemaPlaceDeleteViewModel Delete(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceDeleteViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number,
            };
        }




        #endregion

        #region Movie

        public static MovieListItemViewModel ToListItem(this Movie entity)
        {
            if (entity is null) return null;
            return new MovieListItemViewModel()
            {
                Id_Movie = entity.Id_Movie,
                Title = entity.Title,
                PosterUrl = entity.PosterUrl, 
                Duration = entity.Duration
            };
        }

        public static MovieDetailsViewModel ToDetails (this Movie entity)
        {
            if (entity is null) return null;
            return new MovieDetailsViewModel()
            {
                Id_Movie = entity.Id_Movie,
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration,
            };
        }

        public static Movie ToBLL(this MovieCreateForm entity)
        {
            if (entity is null) return null;
            return new Movie
           (
                0,
                entity.Title,
                entity.SubTitle,
                entity.ReleaseYear,
                entity.Synopsis,
                entity.PosterUrl,
                entity.Duration
            );
        }

        public static MovieEditForm Update(this Movie entity)
        {
            if (entity is null) return null;
            return new MovieEditForm()
            {
                Id_Movie = entity.Id_Movie,
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration,
            };
        }

        public static Movie ToBLL(this MovieEditForm entity)
        {
            if (entity is null) return null;
            return new Movie
           (
                entity.Id_Movie,
                entity.Title,
                entity.SubTitle,
                entity.ReleaseYear,
                entity.Synopsis,
                entity.PosterUrl,
                entity.Duration
            );
        }

        public static MovieDeleteViewModel Delete(this Movie entity)
        {
            if (entity is null) return null;
            return new MovieDeleteViewModel()
            {
                Id_Movie = entity.Id_Movie,
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration,
            };
        }

        #endregion

        #region CinemaRoom

        public static CinemaRoomListItemViewModel ToListItem (this CinemaRoom entity)
        {
            if (entity is null) return null;
            return new CinemaRoomListItemViewModel()
            {
                Id_CinemaRoom = entity.Id_CinemaRoom,
                Number = entity.Number,
                Can3D = entity.Can3D,
                Can4DX = entity.Can4DX,
            };
        }

        public static CinemaRoomDetailsViewModel ToDetails(this CinemaRoom entity)
        {
            if (entity is null) return null;
            return new CinemaRoomDetailsViewModel()
            {
                Id_CinemaRoom = entity.Id_CinemaRoom,
                SeatsCount = entity.SeatsCount,
                Number = entity.Number,
                ScreenWidth = entity.ScreenWidth,
                ScreenHeight = entity.ScreenHeight,
                Can3D = entity.Can3D,
                Can4DX = entity.Can4DX
            };
        }

        #endregion

        #region Diffusion
        public static DiffusionListItemViewModel ToListItem (this Diffusion entity)
        {
            if (entity is null) return null;
            return new DiffusionListItemViewModel()
            {
                Id_Diffusion = entity.Id_Diffusion,
                DiffusionDate = entity.DiffusionDate,
                DiffusionTime = entity.DiffusionTime,
                NbCinemaRoom = entity.CinemaRoom.Number,
                Id_Movie = entity.Id_Movie,
            };
        }

        public static DiffusionDetailsViewModel ToDetails(this Diffusion entity)
        {
            if (entity is null) return null;
            return new DiffusionDetailsViewModel()
            {
                Id_Diffusion = entity.Id_Diffusion,
                DiffusionDate = entity.DiffusionDate,
                DiffusionTime = entity.DiffusionTime,
                AudioLang = entity.AudioLang,
                SubTitleLang = entity.SubTitleLang,
                Id_CinemaRoom = entity.Id_CinemaRoom,
                Id_Movie = entity.Id_Movie,
            };
        }

        #endregion
    }
}
