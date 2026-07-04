using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThirdWebAPI.Filters;
using ThirdWebAPI.Models;

namespace ThirdWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[CustomAuthFilter]
public class EmployeeController : ControllerBase
{
    private List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id=1,
                Name="Rahul",
                Salary=50000,
                Permanent=true,
                DateOfBirth=new DateTime(2001,5,10),
                Department=new Department
                {
                    Id=101,
                    Name="IT"
                },
                Skills=new List<Skill>
                {
                    new Skill{Id=1,Name="Java"},
                    new Skill{Id=2,Name="SQL"}
                }
            }
        };
    }

    [AllowAnonymous]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(GetStandardEmployeeList());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Employee employee)
    {
        return Ok(employee);
    }
}