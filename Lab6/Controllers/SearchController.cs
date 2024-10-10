using Lab6.Interfaces;
using Lab6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lab6.Controllers
{
    public class SearchController : Controller
    {
        private readonly IEmployees _employeesService;


        public SearchController(IEmployees employeesService)
        {
            _employeesService = employeesService;

        }
        [HttpGet]
        public IActionResult ShowSearch(string lastName)
        {
            var employees = _employeesService.employees;

            
            var worker = employees.Where(e => e.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)).ToList();
            return View("ShowSearch", worker);
        }
      
    }
}
