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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = repository.GetEmployee(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                repository.Edit(employee);
                return RedirectToAction("ViewAll");
            }
            return View();
        }

        public IActionResult Remove(int id)
        {
            repository.Delete(id);
            return RedirectToAction("ViewAll");
        }
    }
}
