using EmployeesApp.Web.Services;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using System.Xml;

namespace EmployeesApp.Web.Models
{
    public class CheckIfCompanyEmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var input = value.ToString().Split('@');

            if (input[1] == "company.com")
                return true;
            else
            {
                return false;
            }
        }
    }
}
