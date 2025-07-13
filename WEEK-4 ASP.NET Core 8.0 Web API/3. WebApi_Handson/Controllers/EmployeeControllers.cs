[ApiController]
[Route("api/[controller]")]
[TypeFilter(typeof(CustomAuthFilter))] 
public class EmployeeController : ControllerBase
{
    private static List<Employee> _employees = new List<Employee>();
    public EmployeeController()
    {
        if (_employees.Count == 0)
        {
            _employees = GetStandardEmployeeList();
        }
    }
    private List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 50000,
                Permanent = true,
                DateOfBirth = new DateTime(1990, 1, 1),
                Department = new Department { Id = 101, Name = "HR" },
                Skills = new List<Skill>
                {
                    new Skill { Id = 1, Name = "C#" },
                    new Skill { Id = 2, Name = "SQL" }
                }
            }
        };
    }
    [HttpGet]
    [ProducesResponseType(typeof(List<Employee>), 200)]
    [ProducesResponseType(500)]
    public ActionResult<List<Employee>> Get()
    {
        throw new Exception("Test exception handling"); 
        return Ok(_employees);
    }

    [HttpPost]
    public ActionResult Post([FromBody] Employee emp)
    {
        _employees.Add(emp);
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] Employee emp)
    {
        var existing = _employees.FirstOrDefault(e => e.Id == id);
        if (existing == null) return NotFound();

        existing.Name = emp.Name;
        existing.Salary = emp.Salary;
        existing.Permanent = emp.Permanent;
        existing.Department = emp.Department;
        existing.Skills = emp.Skills;
        existing.DateOfBirth = emp.DateOfBirth;

        return Ok();
    }
}
