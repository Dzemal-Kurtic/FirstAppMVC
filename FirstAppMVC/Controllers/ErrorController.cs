using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.Logging;

namespace FirstAppMVC.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            this.logger = logger;
        }

        [Route("Error")]
        public IActionResult Index()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if ((exceptionHandlerPathFeature != null) && (exceptionHandlerPathFeature.Error != null))
            {
                logger.LogError($"The path {exceptionHandlerPathFeature.Path} threw an exception {exceptionHandlerPathFeature.Error}");
            }
            return View();
        }

        [Route("Error/{statusCode}")]
        public IActionResult statusCodeHandler(int statusCode)
        {
            if (statusCode == 404)
            {
                ViewBag.Message = "Sorry, the page couldn't be found";
            }
            return View("Not found");
        }

    }
}

