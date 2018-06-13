using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BL.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var bla = employeeService.GetAllEmployees();
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
