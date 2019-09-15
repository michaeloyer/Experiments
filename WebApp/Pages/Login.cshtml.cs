using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {

        }

        public void OnPost([FromForm] LoginData loginData)
        {

        }

        public class LoginData
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}