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

    //[HttpPost("{id}")]
    //public IActionResult Delete(int id)
    //{
    //    employeeService.DeleteEmployee(id);
    //    return RedirectToAction(nameof(Index));
    //}

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(Employee employee)
    {
        employeeService.Add(employee);

        return RedirectToAction(nameof(Index));
    }

    //[HttpPost("edit")]
    //public IActionResult Edit(int id, string name, int age)
    //{

    //    employeeService.EditEmployee(id, name, age);

    //    return RedirectToAction(nameof(Index));
    //}

    //[HttpGet("edit/{id}")]
    //public IActionResult Edit(int id)
    //{
    //    var model = employeeService.GetEmployeeById(id);
    //    return View(model);
    //}


}

