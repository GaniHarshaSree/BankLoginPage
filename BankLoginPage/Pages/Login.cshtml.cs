using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankLoginPage.Pages
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (Username == "Harsha" && Password == "ABCD")
            {
                TempData["User"] = Username;
                return RedirectToPage("/Dashboard");
            }
            else
            {
                return RedirectToPage("");
            }
        }
    }
}
