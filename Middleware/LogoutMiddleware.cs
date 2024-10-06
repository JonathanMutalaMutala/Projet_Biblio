using Microsoft.AspNetCore.Identity;

namespace Projet_Biblio.Middleware
{
    public class LogoutMiddleware
    {
        private readonly RequestDelegate _next;

        public LogoutMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> UserManager)
        {
            if (signInManager.Context.User.Identity.IsAuthenticated)
            {
                if (!signInManager.Context.Session.IsAvailable)
                {
                    await signInManager.SignOutAsync();
                }
            }
            await _next(httpContext);
        }

    }
    public static class LogoutMiddlewareExtensions
    {
        public static IApplicationBuilder UseLogoutMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogoutMiddleware>();
        }
    }
}
