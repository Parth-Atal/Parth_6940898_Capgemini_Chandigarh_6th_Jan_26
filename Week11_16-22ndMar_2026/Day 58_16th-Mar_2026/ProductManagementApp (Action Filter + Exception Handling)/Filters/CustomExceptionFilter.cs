using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ProductManagementApp.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            Console.WriteLine("===== EXCEPTION CAUGHT =====");
            Console.WriteLine($"Error: {context.Exception.Message}");

            context.Result = new ContentResult
            {
                Content = "Oops! Something went wrong. Please try again later.",
                ContentType = "text/plain"
            };

            context.ExceptionHandled = true;
        }
    }
}