using Microsoft.AspNetCore.Identity;
using RentACarApp.Data.Entities;

namespace RentACarApp.Extensions
{
    public static class AppBuilderExtensions
    {
        public static IApplicationBuilder SeedAmin(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var services = scopedServices.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task.Run(async () =>
            {

                if (await roleManager.RoleExistsAsync("Administrator"))
                {
                    return;
                }

                var role = new IdentityRole { Name = "Administrator" };

                await roleManager.CreateAsync(role);

                var admin = await userManager.FindByNameAsync("admin@mail.com");

                await userManager.AddToRoleAsync(admin, role.Name);

            }).GetAwaiter().GetResult();

            return app;

        }
    }
}                

            
        
    

