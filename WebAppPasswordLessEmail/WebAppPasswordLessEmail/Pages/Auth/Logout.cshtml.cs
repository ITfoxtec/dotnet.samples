using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppPasswordLessEmail.Pages.Auth
{
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public class LogoutModel : PageModel
    {
        public IActionResult OnPost()
        {
            var redirectUri = Url.Page("/Index") ?? "/";
            if (User.Identity?.IsAuthenticated != true)
            {
                return LocalRedirect(redirectUri);
            }

            return SignOut(new AuthenticationProperties { RedirectUri = redirectUri },
                CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}

