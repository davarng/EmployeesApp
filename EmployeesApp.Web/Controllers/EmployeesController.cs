using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers;

public class EmployeesController : Controller
{
    static EmployeeService employeeService = new EmployeeService();

    public EmployeesController() { }

    [HttpGet("")]
    public IActionResult Index()
    {
        var model = employeeService.GetAllEmployees();
        return View(model);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(Employee employee)
    {
         if (!ModelState.IsValid)
            return View();
        
        employeeService.Add(employee);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet("details/{id}")]
    public IActionResult Details(int id)
    {
        var model = employeeService.GetEmployeeById(id);
        return View(model);
    }

}

