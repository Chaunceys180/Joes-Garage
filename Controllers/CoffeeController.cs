using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoesGarage.Controllers
{
    public class CoffeeController : Controller
    {
        // GET: Coffee
        public ActionResult Random()
        {
            var coffee = new Models.Coffee() { Name = "Houndurian Blend" };
            
            return View(coffee);
        }
    }
}