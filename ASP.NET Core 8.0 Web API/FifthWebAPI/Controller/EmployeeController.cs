using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FifthWebAPI.Models;

namespace FifthWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "Admin,POC")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = new()
    {
        new Employee
        {
            Id = 1,
            Name = "Rahul",
            Department = "IT",
            Salary = 50000
        },
        new Employee
        {
            Id = 2,
            Name = "Ankit",
            Department = "HR",
            Salary = 45000
        },
        new Employee
        {
            Id = 3,
            Name = "Priya",
            Department = "Finance",
            Salary = 60000
        }
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(employees);
    }
}