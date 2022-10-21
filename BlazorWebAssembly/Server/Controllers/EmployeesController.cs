
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebAssembly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public static List<Manager> managers = new List<Manager> {
            new Manager {Id = 1, Name ="Tekla"},
            new Manager {Id = 2, Name ="Shehani"}
        };
        public static List<Employees> employees = new List<Employees> {
            new Employees {
                Id = 1, 
                FirstName = "Dilka", 
                LastName = "Prabhashi", 
                TelephoneNo = 01425369,
                Manager = managers[0]
            },

            new Employees {
                Id = 2,
                FirstName = "Shani",
                LastName = "Madushika",
                TelephoneNo = 01125339,
                Manager = managers[1]
            },

        };
        [HttpGet]
        public async Task<ActionResult<List<Employees>>> GetEmployees()
        {
            return Ok(employees);
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Employees>> GetSingleEmployee(int Id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == Id);
            if(employee == null)
            {
                return NotFound("Sorry, no employee here. ");
            }
            return Ok(employee);
        }
    }
}
