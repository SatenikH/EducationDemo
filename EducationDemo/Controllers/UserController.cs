using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EducationDemo.Controllers
{
    [Route("api/user")]
    [ApiController]
    [Authorize(Roles = "Admin,User")] 
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUserData()
        {
            return Ok("It is for both Admin's and user's data");
        }
    }
}
