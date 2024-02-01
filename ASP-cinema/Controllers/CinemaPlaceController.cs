using Microsoft.AspNetCore.Mvc;
using BLL_cinema.Entities;
using ASP_cinema.Models;
using ASP_cinema.Handlers;
using Shared.Repositories;

namespace ASP_cinema.Controllers
{
    public class CinemaPlaceController : Controller
    {
        private readonly ICinemaPlaceRepository<CinemaPlace> _cinemaPlaceRepository;
        public CinemaPlaceController(ICinemaPlaceRepository<CinemaPlace> cinemaPlaceRepository)
        {
            _cinemaPlaceRepository = cinemaPlaceRepository;
        }

        // GET: CinemaPlaceController
        public ActionResult Index()
        {
            IEnumerable<CinemaPlaceListItemViewModel> model = _cinemaPlaceRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: CinemPlaceController/Details/5
        public ActionResult Details(int id) 
        { 
            return View();
        }
    }
    
}
