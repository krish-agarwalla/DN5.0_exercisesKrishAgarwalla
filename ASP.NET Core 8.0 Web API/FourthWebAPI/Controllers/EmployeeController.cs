using Microsoft.AspNetCore.Mvc;
using FourthWebAPI.Models;

namespace FourthWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = new()
    {
        new Employee{Id=1,Name="Rahul",Salary=50000,Department="IT"},
        new Employee{Id=2,Name="Ankit",Salary=45000,Department="HR"},
        new Employee{Id=3,Name="Priya",Salary=60000,Department="Finance"}
    };

    [HttpGet]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(employees);
    }

    [HttpPost]
    public ActionResult<Employee> Post([FromBody] Employee employee)
    {
        employees.Add(employee);

        return Ok(employee);
    }

    [HttpPut("{id}")]
    public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

        if (existingEmployee == null)
        {
            return BadRequest("Invalid employee id");
        }

        existingEmployee.Name = employee.Name;
        existingEmployee.Salary = employee.Salary;
        existingEmployee.Department = employee.Department;

        return Ok(existingEmployee);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            return BadRequest("Invalid employee id");
        }

        employees.Remove(employee);

        return Ok("Employee Deleted Successfully");
    }
}