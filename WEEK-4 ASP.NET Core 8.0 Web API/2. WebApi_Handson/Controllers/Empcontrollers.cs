using Microsoft.AspNetCore.Mvc;

namespace WebApiHandson.Controllers
{
    [ApiController]
    [Route("Emp")]
    public class EmpController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new[] { "Emp1", "Emp2" });

        [HttpPost]
        public IActionResult Post() => Ok("Employee added");

        [HttpPut]
        public IActionResult Put() => Ok("Employee updated");

        [HttpDelete]
        public IActionResult Delete() => Ok("Employee deleted");
    }
}