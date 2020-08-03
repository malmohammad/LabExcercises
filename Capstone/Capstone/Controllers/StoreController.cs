using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.Controllers
{
    public class StoreController : Controller
    {
        public async Task <IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> CheckOut()
        {
            return View();
        }

       
    }
}