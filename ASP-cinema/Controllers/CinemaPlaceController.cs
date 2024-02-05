using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BLL_cinema.Entities;
using ASP_cinema.Models;
using ASP_cinema.Handlers;
using Shared.Repositories;
using System.Reflection;
using static System.Collections.Specialized.BitVector32;

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
            try
            {
                CinemaPlaceEditForm model = _cinemaPlaceRepository.Get(id).Update();
                if (model is null) throw new ArgumentOutOfRangeException(nameof(id), $"Pas de cinema avec l'identifiant {id}");
                return RedirectToAction(nameof(Index), new { id });
            }

            catch
            {
                return View();
            }
        }

        // POST: CinemaPlaceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CinemaPlaceEditForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                _cinemaPlaceRepository.Update(form.ToBLL());
                return RedirectToAction(nameof(Details), new {id});
            }
            catch
            {
                return View(form);
            }
        }

        // GET: CinemaPlaceController/Delete/5
        public ActionResult Delete(int id)
        {

            try
            {
                CinemaPlaceDeleteViewModel model = _cinemaPlaceRepository.SingleOrDefault(d => d.Id_CinemaPlace == id).ToDelete();
                if (model is null) throw new InvalidDataException();
                return View(model);
            }

            catch (Exception) 
            {
                TempData["ErrorMessage"] = $"L'identifiant {id} est invalide.";
                return RedirectToAction(nameof(Index));
            }

        }

        // POST: CinemaPlaceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CinemaPlaceDeleteViewModel model)
        {
            try
            {
                _cinemaPlaceRepository.Remove(_cinemaPlaceRepository.SingleOrDefault(d =>d.Id_CinemaPlace == id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
    
}
