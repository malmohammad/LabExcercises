using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab23.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab23.Controllers
{
    public class MovieController : Controller
    {
        private object _dbContext;

        private List<Movie> _moviesList { get; set; }
        public MovieController()
        {
            _moviesList = new List<Movie>
            {
                new Movie("Batman", TypeGenre.Action),
                new Movie("Extraction", TypeGenre.Action),
                new Movie("Wrong Missy", TypeGenre.Comedy),
                new Movie("Step Brothers", TypeGenre.Comedy),
                new Movie("The Hustle", TypeGenre.Comedy),
                new Movie("The Invisible Man", TypeGenre.Horror),
                new Movie("WALL-E", TypeGenre.Drama),
                new Movie("Scareface", TypeGenre.Drama),
                new Movie("Avengers", TypeGenre.Drama),
                new Movie("The Hunt", TypeGenre.Action),
                new Movie("Jumanji", TypeGenre.Comedy),
                new Movie("The Hangover", TypeGenre.Comedy),
                new Movie("Doctor Sleep", TypeGenre.Horror),
                new Movie("Thor", TypeGenre.Drama)
            };
        }



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ResultByTitle(Movie model)
        {
            ViewData["List"] = _moviesList;

            return View(model);
        }
        public IActionResult ResultByGenre(Movie model)
        {
            ViewData["List"] = _moviesList;

            return View(model);
        }

        public IActionResult ResultByRunTime(Movie model)
        {
            ViewData["List"] = _moviesList;

            return View(model);
        }
        [HttpPost]
        public IActionResult Create([Bind("Title", "Genre", "RunTime")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            _dbContext.Movie.Add(movie);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}