using Microsoft.AspNetCore.Mvc;
using PlakDukkani.BLL.Abstract;
using PlakDukkani.BLL.Concrete.ResultServiceBLL;
using PlakDukkani.ViewModel.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlakDukkani.UI.MVC.Controllers
{
    public class UserController : Controller
    {
        IUserBLL userService;
        public UserController(IUserBLL userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserCreateVM user)
        {
            if (ModelState.IsValid)
            {
                //post edilen data doğru data
                //data ile ilgili yapılması gereken kontrol varsa kontrol et 
                ResultService<UserCreateVM> resultService = userService.Insert(user);
                //data veritabanına kayıt edilecek
                //mail gönder
            }
            return View();
        }

        public IActionResult ActivedUser(Guid guid) 
        {
            //KUllanıcı aktifleştir.
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

    }
}
