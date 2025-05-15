using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter a name")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Must be at least one letter")]
        [RegularExpression(@"^\p{L}+$", ErrorMessage = "Letters only")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter an E-mail")]
        [EmailAddress(ErrorMessage = "Enter a valid E-mail")]
        [CheckIfCompanyEmail(ErrorMessage = "Must enter the company email (@company.com)")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
