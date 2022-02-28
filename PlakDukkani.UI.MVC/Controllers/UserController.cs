using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlakDukkani.UI.MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            //TODO : Login Template'ini giydir
            return View();
        }

        public IActionResult Register()
        {
            //TODO : Login Template'ini kullanarak register sayfası oluştur.
            return View();
        }
    }
}
