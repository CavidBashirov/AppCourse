using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Service.Helpers.Exceptions;

namespace App.Middlewares
{
    public class CustomAuthorizationHandler : AuthorizationHandler<RolesAuthorizationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RolesAuthorizationRequirement requirement)
        {
            if (!context.User.Identity?.IsAuthenticated ?? false)
            {
                context.Fail();
                return Task.CompletedTask;
            }

            if (context.User.IsInRole("Admin"))
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail(); // Mark authorization failed
                var httpContext = context.Resource as HttpContext;
                httpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
            }

            return Task.CompletedTask;
        }
    }
}
