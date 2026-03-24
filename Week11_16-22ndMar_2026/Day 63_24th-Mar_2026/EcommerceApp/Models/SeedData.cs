using Microsoft.AspNetCore.Identity;

public static class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

        string[] roles = { "Admin", "User" };

        // Create roles
        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
        }

        var adminEmail = "parth@gmail.com";
        var admin = await userManager.FindByEmailAsync(adminEmail);

        if (admin == null)
        {
            // Create admin
            admin = new IdentityUser
            {
                UserName = adminEmail,
                Email = adminEmail
            };

            await userManager.CreateAsync(admin, "Parth@123");
        }

        // 🔥 THIS IS THE IMPORTANT FIX
        if (!await userManager.IsInRoleAsync(admin, "Admin"))
        {
            await userManager.AddToRoleAsync(admin, "Admin");
        }
    }
}