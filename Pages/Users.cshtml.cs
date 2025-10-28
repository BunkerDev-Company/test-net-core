using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExampleApplication.Pages
{
    public class UsersModel : PageModel
    {
        public DateTime UtcNow = DateTime.UtcNow;
        public void OnGet()
        {

        }
    }
}
