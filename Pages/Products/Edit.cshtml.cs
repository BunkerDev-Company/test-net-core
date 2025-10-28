using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExampleApplication.Pages.Products
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public string NameProduct { get; set; } = "";
        [BindProperty]
        public string CodeProduct { get; set; } = "";
        public void OnGet()
        {
            NameProduct = "Товар";
            CodeProduct = "001";
        }

        public void OnPost()
        {
            var name = NameProduct;
            var code = CodeProduct;

            var i = 0;
        }
    }
}
