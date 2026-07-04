using Microsoft.AspNetCore.Mvc;
using SecondWebAPI.Models;

namespace SecondWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    static List<Employee> employees = new()
    {
        new Employee { Id = 1, Name = "Rahul", Department = "IT", Salary = 50000 },
        new Employee { Id = 2, Name = "Ankit", Department = "HR", Salary = 40000 },
        new Employee { Id = 3, Name = "Priya", Department = "Finance", Salary = 60000 }
    };

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        return Ok(employees);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Post(Employee employee)
    {
        employees.Add(employee);
        return Ok("Employee Added Successfully");
    }
}