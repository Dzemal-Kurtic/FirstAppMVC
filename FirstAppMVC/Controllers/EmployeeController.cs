using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepository repository;

        public EmployeeController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult ViewAll()
        {
            var model = repository.GetAllEmployees();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                repository.Add(employee);
                return RedirectToAction("ViewAll");
            }
            return View();
        }
    }
}
