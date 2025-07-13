using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class CustomAuthFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.HttpContext.Request.Headers.TryGetValue("Authorization", out var authHeader))
        {
            context.Result = new BadRequestObjectResult("Invalid request - No Auth token");
            return;
        }

        if (!authHeader.ToString().Contains("Bearer"))
        {
            context.Result = new BadRequestObjectResult("Invalid request - Token present but Bearer unavailable");
        }
    }
}
