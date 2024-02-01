using Shared.Repositories;

namespace ASP_cinema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Ajout services par injection de dépendance:
            
            builder.Services.AddScoped<ICinemaPlaceRepository<BLL_cinema.Entities.CinemaPlace>, BLL_cinema.Services.CinemaPlaceService>();
            builder.Services.AddScoped<ICinemaPlaceRepository<DAL_cinema.Entities.CinemaPlace>, DAL_cinema.Services.CinemaPlaceService>();




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