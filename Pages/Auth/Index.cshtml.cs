using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExampleApplication.Pages.Auth
{
    public class IndexModel : PageModel
    {
        public bool isAuth = false;
        public bool isError = false;
        [BindProperty]
        public string Password { get; set; } = "";

        public void OnGet()
        {
            isAuth = false;
            isError = false;
            Password = "";
        }

        public void OnPost() {
            if (Password == "admin")
            {
                Password = "";
                isAuth = true;
                isError = false;
            }
            else
            {
                 isError = true;
            }
        }
    }
}
