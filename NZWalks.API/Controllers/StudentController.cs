using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            string[] studentArray = { "Suraj", "Sonam", "Ajay" };
            return Ok(studentArray);
        }
    }
}
