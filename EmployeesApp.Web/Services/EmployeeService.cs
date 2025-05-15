using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = 
            [
            new Employee {Id = 10, Name = "Niklas", Email = "niklas@company.com" },
            new Employee {Id = 43, Name = "Tobias", Email = "tobias@company.com"},
            new Employee {Id = 26, Name = "David", Email = "david@company.com"}
            ];

        public void Add(Employee employee)
        {
            if (employees.Count == 0)
            {
                employee.Id = 1;
            }
            else
            {
                employee.Id = employees.Max(o => o.Id) + 1;
            }

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

        public bool EmailExists(string email)
        {
            return employees.Any(e => e.Email == email);
        }
    }
}
