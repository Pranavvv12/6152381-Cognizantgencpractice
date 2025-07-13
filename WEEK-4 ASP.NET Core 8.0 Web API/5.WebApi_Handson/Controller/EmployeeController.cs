using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebApiProject.Models; 
[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "Admin,POC")] 
public class EmployeeController : ControllerBase
{
    private static List<Employee> _employees = new List<Employee>
    {
        new Employee
        {
            Id = 1,
            Name = "John",
            Salary = 50000,
            Permanent = true,
            Department = new Department { Id = 1, Name = "HR" },
            Skills = new List<Skill> { new Skill { Id = 1, Name = "C#" } },
            DateOfBirth = new DateTime(1990, 1, 1)
        }
    };

    [HttpGet]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(_employees);
    }
}
