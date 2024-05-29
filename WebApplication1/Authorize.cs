using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication1.Services;

namespace WebApplication1
{
    public class Authorize : Attribute, IActionFilter
    {

        public async void OnActionExecuting(ActionExecutingContext context)
        {
            AuthorizeService authService = new AuthorizeService();
            string authtoken = context.HttpContext.Connection.RemoteIpAddress?.ToString();
            Console.WriteLine(authService.Log(authtoken));
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
