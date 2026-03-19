using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ProductManagementApp.Filters
{
    public class LogActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("===== LOG START =====");
            Console.WriteLine($"Action: {context.ActionDescriptor.DisplayName}");
            Console.WriteLine($"Time: {DateTime.Now}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("===== LOG END =====");
            Console.WriteLine();
        }
    }
}