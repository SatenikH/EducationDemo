using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EducationDemo.Controllers
{
    [Route("api/admin")]
    [ApiController]
    [Authorize(Roles = "Admin")] 
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAdminData()
        {
            return Ok("It is Admin's rolls data");
        }
    }
}
