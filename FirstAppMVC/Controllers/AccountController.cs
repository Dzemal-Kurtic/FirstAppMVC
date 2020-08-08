using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAppMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstAppMVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register(RegisterViewModel model)
        {
            return View();
        }
    }
}
