using Lab6.Models;
using Lab6.Interfaces;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lab6.Mocks
{
    public class MockEmployees : IEmployees
    {
       
        private static List<Employees> _employeeList = new List<Employees>
        {
            new Employees{Id=1,FirstName="Jane",LastName="Jackson", Email="jayjay@gmail.com", DateTime="11/2003"},
            new Employees{Id=2, FirstName="Bob", LastName="Smith",Email="bobsmth@gmail.com",DateTime="7/2009"},
            new Employees{Id=3, FirstName="Oleksandra", LastName="Omelyanenko",Email="alexaom11111@gmail.com", DateTime="12/2014"}
        };

     
        public IEnumerable<Employees> employees
        {
            get { return _employeeList; }
        }

    
        public void AddEmployee(Employees newEmployee)
        {
            _employeeList.Add(newEmployee);
        }
        public void DeleteEmployee(int id)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
        }
        public void UpdateEmployee(Employees updatedEmployee)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == updatedEmployee.Id);
            if (employee != null)
            {
                employee.FirstName = updatedEmployee.FirstName;
                employee.LastName = updatedEmployee.LastName;
                employee.Email = updatedEmployee.Email;
                employee.DateTime = updatedEmployee.DateTime;
            }
        }
    }
}
