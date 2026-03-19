using EmployeePortalApp.Filters;

namespace EmployeePortalApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ✅ Add MVC + Global Exception Filter
            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add<CustomExceptionFilter>();
            });

            // ✅ Enable Session
            builder.Services.AddSession();

            // ✅ Register Logging Filter (for HR Module)
            builder.Services.AddScoped<LogActionFilter>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                // ❌ Removed UseExceptionHandler to avoid conflict with custom filter
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // ✅ Enable Session Middleware
            app.UseSession();

            app.UseAuthorization();

            app.MapStaticAssets();

            // ✅ Default route → Login Page
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Login}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}