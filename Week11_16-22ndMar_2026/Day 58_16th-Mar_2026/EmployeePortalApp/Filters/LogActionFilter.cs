using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeePortalApp.Filters
{
    public class LogActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"[LOG] Action: {context.ActionDescriptor.DisplayName}");
            Console.WriteLine($"Time: {DateTime.Now}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("[LOG] Completed");
        }
    }
}