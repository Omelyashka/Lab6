using Lab6.Interfaces;
using Lab6.Mocks;
using Lab6.Models;
using Microsoft.AspNetCore.Mvc;


namespace Lab6.Controllers
{
    public class AllEmployeesController : Controller
    {

        private readonly IEmployees _employeesService;

        public AllEmployeesController(IEmployees employeesService)
        {
            _employeesService = employeesService;
        }


        public IActionResult List()
        {
            var employees = _employeesService.employees;
            foreach (var employee in employees) { 
            Console.WriteLine(employee.Id);}
            return View(employees);
        }

       [HttpPost] public IActionResult Delete(int id)
        {
            
            _employeesService.DeleteEmployee(id);
            return RedirectToAction("List");


        }
       
        [HttpPost]
        public IActionResult Edit(Employees updatedEmployee)
        {
            _employeesService.UpdateEmployee(updatedEmployee); 
            return Json(new { success = true }); 
        }


    }
}
