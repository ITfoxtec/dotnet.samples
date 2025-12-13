using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAppPasswordLessEmail.Controllers
{
    [AllowAnonymous]
    [Route("[controller]/[action]")]
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            var redirectUri = Url.Content("~/");
            if (User.Identity?.IsAuthenticated == true)
            {
                return LocalRedirect(redirectUri);
            }

            return Challenge(new AuthenticationProperties { RedirectUri = redirectUri },
                OpenIdConnectDefaults.AuthenticationScheme);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            var redirectUri = Url.Content("~/");
            if (User.Identity?.IsAuthenticated != true)
            {
                return LocalRedirect(redirectUri);
            }

            return SignOut(new AuthenticationProperties { RedirectUri = redirectUri },
                CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}