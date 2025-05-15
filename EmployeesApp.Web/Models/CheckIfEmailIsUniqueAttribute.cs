using EmployeesApp.Web.Services;
using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models
{
    public class CheckIfEmailIsUniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var list = EmployeeService.GetAllEmployees();

            var resultOfList = list.Any(e => (string)value == e.Email);

           

            if (resultOfList)
            {
                return new ValidationResult("Email is already in use.");

            }

            return ValidationResult.Success;
        }
    }
}
