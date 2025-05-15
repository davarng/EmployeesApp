using EmployeesApp.Web.Services;
using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models
{
    public class CheckIfEmailIsUniqueAttribute (EmployeeService service): ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var list = service.GetAllEmployees();
            return list.Any(e => value != e.Email);
        }
    }
}
