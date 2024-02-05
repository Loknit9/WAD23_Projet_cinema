using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BLL_cinema.Entities;
using ASP_cinema.Models;
using ASP_cinema.Handlers;
using Shared.Repositories;
using System.Reflection;

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
            CinemaPlaceDetailsViewModel model = _cinemaPlaceRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: CinemaPlaceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (CinemaPlaceCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                int id = _cinemaPlaceRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaPlaceController/Edit/5
        public ActionResult Edit(int id)
        {
            CinemaPlaceEditForm model = _cinemaPlaceRepository.Get(id).ToEdit();
            if (model is null) throw new ArgumentOutOfRangeException(nameof(id), $"Pas de cinema avec l'identifiant {id}");
            return View(model);
        }

        // POST: CinemaPlaceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CinemaPlaceEditForm form)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaPlaceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CinemaPlaceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CinemaPlaceEditForm form)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
    
}
