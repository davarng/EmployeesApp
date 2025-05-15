using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = [new Employee { Id = 10, Name = "Niklas", Email = "Test" }];

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.SingleOrDefault(e => e.Id == id);
        }

        public Employee[] GetAllEmployees()
        {
            return employees.ToArray();
        }

    }
}
