﻿using ASP_cinema.Models;
using BLL_cinema.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Repositories;
using ASP_cinema.Handlers;
using System.Reflection;
using static System.Collections.Specialized.BitVector32;

namespace ASP_cinema.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository<Movie> _movieRepository;
        public MovieController(IMovieRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }
        // GET: MovieController
        public ActionResult Index()
        {
            IEnumerable<MovieListItemViewModel> model = _movieRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            MovieDetailsViewModel model = _movieRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                int id = _movieRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new {id});
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                MovieEditForm model = _movieRepository.Get(id).Update();
                if (model is null) throw new ArgumentOutOfRangeException(nameof(id), $"Pas de film avec l'identifiant {id}");
                return View(model);
            }

            catch
            {
                return View();
            }
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MovieEditForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                _movieRepository.Update(form.ToBLL());
                return RedirectToAction(nameof(Details), new {id});
            }
            catch
            {
                return View(form);
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                MovieDeleteViewModel model = _movieRepository.Get(id).Delete();
                if (model is null) throw new InvalidDataException();
                return View(model);
            }

            catch (Exception)
            {
                TempData["ErrorMessage"] = $"L'identifiant {id} est invalide.";
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MovieDeleteViewModel model)
        {
            try
            {
                _movieRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
