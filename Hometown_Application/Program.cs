using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Hometown_Application.Data;
using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel;
using Hometown_Application.Seed;
public class Program
{
    public static async Task Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connectionString));

        builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDBContext>();

        builder.Services.AddControllers().AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;

        });


        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddRazorPages();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

         using (var scope = app.Services.CreateScope())
         {
             var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
             var roles = new[] { "Admin", "HomeOwner", "Staff" };


             foreach (var role in roles)
             {
                 if (!await roleManager.RoleExistsAsync(role))
                     await roleManager.CreateAsync(new IdentityRole(role));
             }
         }

       /* using (var scope = app.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // Define roles with fixed IDs
            var roles = new List<IdentityRole>
            {
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "HomeOwner", NormalizedName = "HOMEOWNER" },
                new IdentityRole { Id = "3", Name = "Staff", NormalizedName = "STAFF" }
            };
                 
            // Ensure roles exist in the database
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role.Name))
                    await roleManager.CreateAsync(role);
            }

            // Admin user credentials
            string email = "admin@admin.com";
            string password = "Admin1234*";

            var existingUser = await userManager.FindByEmailAsync(email);
            if (existingUser == null)
            {
                var user = new ApplicationUser
                {
                    UserName = email,
                    Email = email,
                    FirstName = "Admin",
                    LastName = "User",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
       */


           using (var scope = app.Services.CreateScope())
           {
               var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>(); // FIXED

               string email = "admin@admin.com";
               string password = "Admin1234*";

               if (await userManager.FindByEmailAsync(email) == null)
               {
                   var user = new ApplicationUser
                   {
                       UserName = email,
                       Email = email,
                       FirstName = "Admin",
                       LastName = "User"
                   };

                   var result = await userManager.CreateAsync(user, password);

                   if (result.Succeeded)
                   {
                       await userManager.AddToRoleAsync(user, "Admin");
                   }
               }
           }



        app.Run();
    } 
}
