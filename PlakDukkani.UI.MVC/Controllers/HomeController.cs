using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlakDukkani.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AlbumStore() 
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
