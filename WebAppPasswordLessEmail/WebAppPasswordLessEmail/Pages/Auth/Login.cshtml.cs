using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppPasswordLessEmail.Pages.Auth
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        public IActionResult OnGet()
        {
            var redirectUri = Url.Page("/Index") ?? "/";
            if (User.Identity?.IsAuthenticated == true)
            {
                return LocalRedirect(redirectUri);
            }

            return Challenge(new AuthenticationProperties { RedirectUri = redirectUri },
                OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}

