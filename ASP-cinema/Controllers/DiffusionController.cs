using ASP_cinema.Handlers;
using ASP_cinema.Models.Diffusion;
using BLL_cinema.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Repositories;

namespace ASP_cinema.Controllers
{
    public class DiffusionController : Controller
    {
        private readonly IDiffusionRepository<Diffusion> _diffusionRepository;

        public DiffusionController(IDiffusionRepository<Diffusion> diffusionRepository)
        {
            _diffusionRepository = diffusionRepository;
        }

        // GET: DiffusionController
        public ActionResult Index()
        {
            IEnumerable<DiffusionListItemViewModel> model = _diffusionRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: DiffusionController/Details/5
        public ActionResult Details(int id)
        {   
            DiffusionDetailsViewModel model = _diffusionRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: DiffusionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiffusionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DiffusionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiffusionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: DiffusionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DiffusionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
