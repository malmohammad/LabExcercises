using Lab21.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab21.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Registration registration)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(registration);
        }
    }
}