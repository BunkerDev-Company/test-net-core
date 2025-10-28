using ExampleApplication.Helpers;
using ExampleApplication.Pages.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracticeController : ControllerBase
    {
        [HttpGet]
        private ActionResult GetNameUser()
        {
            int a = 5;
            int b = 10;

            int result = a + b;
            return Ok(result);
        }

        [HttpGet("GetUser")]
        public ActionResult GetNameUser2()
        {
            string nameUser = "Пользователь";
            return Ok(nameUser);
        }

        [HttpGet("GetBool")]
        public bool GetBool()
        {
            bool status = true;

            return status;
        }

        [HttpGet("GetDouble/{num}")]
        public int GetDouble(int num)
        {
            return num * 2;
        }

        [HttpGet("GetString/{str}")]
        public string GetString(string str)
        {
            Product product = new Product();
            return str;
        }

        [HttpGet("GetSum")]
        public int GetSum(int num, int num2, int num3)
        {
            return num * num2 * num3;
        }

        [HttpGet("GetProduct")]
        public ActionResult GetProduct()
        {
            var product = new Product()
            {
                Name = "Ботинки",
                Code = "009"
            };
            return Ok(product);
        }

        [HttpGet("GetUserDto")]
        public ActionResult GetUserDto()
        {
            var user = new
            {
                Fio = "Луканин М.С",
                Age = 19,
                Balance = 0,
                Email = "blabla@mail.ru"
            };

            return Ok(user);
        }
    }

    public class UserDto()
    {
        public string Fio;
        public int Age;
        public float Balance;
        public string Email;
    }
}
