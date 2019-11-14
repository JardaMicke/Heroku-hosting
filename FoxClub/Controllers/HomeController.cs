using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Services;
using FoxClub.Models;

namespace FoxClub.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        
        private IFox foxServices;

        public HomeController(IFox foxServices)
        {
           // this.Fox = fox;
            this.foxServices = foxServices;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("createFox")]
        public IActionResult CreateFox(string name)
        {
            var fox = new Fox(name);
            foxServices.AddFoxToList(fox);
            return RedirectToAction("information", "home", new { name = name });
        }

        [Route("check")]
        [HttpPost]
        public IActionResult Check(string name)
        {
            foreach (var fox in foxServices.ListOfFoxes)
            {
                if (name != null && name == fox.Name)
                {
                    return RedirectToAction("information", "home", new { name = name });
                }
            }
            return RedirectToAction("createFox", "home", new { name = name });
        }

        [Route("information")]
        public IActionResult Information(string name)
        { 
            return View(foxServices.FindFoxByName(name));
        }

    }
}