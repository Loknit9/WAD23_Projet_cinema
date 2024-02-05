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
            CinemaPlaceDeleteViewModel model = _cinemaPlaceRepository.Get(id).Delete();
            if (model is null) throw new ArgumentOutOfRangeException(nameof(id), $"Pas de cinema avec l'identifiant {id}");
            return View(model);
        }

        // POST: CinemaPlaceController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CinemaPlaceDeleteViewModel form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                CinemaPlace data = _cinemaPlaceRepository.Get(id);
                if (data is null) ModelState.AddModelError(nameof(id), "Pas de cinema avec cet identifiant");
                if (!ModelState.IsValid) throw new Exception();

                _cinemaPlaceRepository.Delete(data.ToBLL());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(form);
            }
        }
    }
    
}
