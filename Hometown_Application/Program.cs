using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Hometown_Application.Data;
using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel;
using Hometown_Application.Seed;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.HttpOverrides;
using Hometown_Application.Controllers;
using QuestPDF;
using Hometown_Application.Hubs;
using Stripe;
using Hometown_Application;
public class Program
{
    public static async Task Main(string[] args)
    {
        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        builder.Services.AddScoped<CustomValidateAntiForgeryTokenAttribute>();

        // Add DbContext
        builder.Services.AddDbContext<ApplicationDBContext>(options =>
            options.UseSqlServer(connectionString));

        // Add Identity
        builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
        })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDBContext>();

        // Configure JSON serialization
        builder.Services.AddControllers().AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
        });

        // Add services to the container
        builder.Services.AddControllersWithViews();
        builder.Services.AddRazorPages();

        // Add IHttpContextAccessor for accessing user identity in controllers
        builder.Services.AddHttpContextAccessor();

        // Add CORS policy with dynamic origin
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowLocalhost", policyBuilder =>
            {
                policyBuilder
                    .SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost") // Allow any localhost origin
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .WithExposedHeaders("*"); // Allow all exposed headers
            });
        });

        // Configure cookie policy to require HTTPS
        builder.Services.Configure<CookiePolicyOptions>(options =>
        {
            options.CheckConsentNeeded = context => true;
            options.MinimumSameSitePolicy = SameSiteMode.Lax;
            options.Secure = CookieSecurePolicy.Always; // Enforce cookies over HTTPS only
        });

        // Configure Identity cookies to require HTTPS
        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Cookies only sent over HTTPS
            options.Cookie.SameSite = SameSiteMode.Lax;
        });

       // var stripeSettings = builder.Configuration.GetSection("StripeSettings").Get<StripeSettings>();
        //builder.Services.AddSingleton(stripeSettings);

        // Add SignalR
        builder.Services.AddSignalR();
        builder.Services.AddAuthentication();
        builder.Services.AddAuthorization();

        var app = builder.Build();

        // Forward headers to handle reverse proxy or load balancer scenarios
        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.XForwardedProto
        });

        // Custom middleware to log requests and debug HTTPS redirection
        app.Use(async (context, next) =>
        {
            Console.WriteLine($"Request: {context.Request.Scheme}://{context.Request.Host}{context.Request.Path}");
            if (!context.Request.IsHttps)
            {
                Console.WriteLine("Redirecting to HTTPS...");
            }
            await next();
        });

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        // Enable CORS BEFORE Authentication and Authorization
        app.UseCors("AllowLocalhost");

        app.UseAuthentication();
        app.UseAuthorization();

        // Apply cookie policy
        app.UseCookiePolicy();

        // Map endpoints AFTER authentication and authorization middleware are in place.
        app.MapHub<ChatHub>("/chatHub");
        app.MapHub<NotificationHub>("/notificationHub");
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

        // Seed roles
       /* using (var scope = app.Services.CreateScope())
        {
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var roles = new[] { "Admin", "HomeOwner", "Staff" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }
        }*/

        // Seed an admin user
        using (var scope = app.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

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
