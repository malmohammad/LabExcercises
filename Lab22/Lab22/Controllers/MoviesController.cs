using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab22.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab22.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> _moviesList { get; set; }
        public MoviesController()
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
    }
}