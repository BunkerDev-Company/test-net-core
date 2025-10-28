using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("GetNameUser")]
        public ActionResult GetNameUser()
        {
            var name = "Иван Иванов";

            return Ok(name);
        }

        [HttpGet("GetAgeUser")]
        public ActionResult GetAgeUser()
        {
            var age = "25";

            return Ok(age);
        }

        [HttpGet("GetMyText/{text}")]
        public ActionResult GetNameUser(string text)
        {
            return Ok(text);
        }
    }
}
