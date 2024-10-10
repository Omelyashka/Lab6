using Lab6.Models;

namespace Lab6.Interfaces
{
    public interface IEmployees
    {
       public IEnumerable<Employees> employees { get;  }
        void AddEmployee(Employees newEmployee);
        void DeleteEmployee(int id);
        public void UpdateEmployee(Employees newEmployee);
        

    }
}
