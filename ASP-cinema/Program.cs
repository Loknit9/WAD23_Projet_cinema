using Shared.Repositories;
using BLL = BLL_cinema;
using DAL = DAL_cinema;

namespace ASP_cinema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string test = builder.Configuration.GetConnectionString("DB-Projet-Cinema");
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Ajout services par injection de dépendance:
           
            builder.Services.AddScoped<ICinemaPlaceRepository<BLL.Entities.CinemaPlace>, BLL.Services.CinemaPlaceService>();
            builder.Services.AddScoped<IMovieRepository<BLL.Entities.Movie>, BLL.Services.MovieService>();
            builder.Services.AddScoped<ICinemaRoomRepository<BLL.Entities.CinemaRoom>, BLL.Services.CinemaRoomService>();

            builder.Services.AddScoped<ICinemaPlaceRepository<DAL.Entities.CinemaPlace>, DAL.Services.CinemaPlaceService>();
            builder.Services.AddScoped<IMovieRepository<DAL.Entities.Movie>, DAL.Services.MovieService>();
            builder.Services.AddScoped<ICinemaRoomRepository<DAL.Entities.CinemaRoom>, DAL.Services.CinemaRoomService>();




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}