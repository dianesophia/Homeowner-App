using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Hometown_Application.Data;
using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Seed;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.HttpOverrides;
using Hometown_Application.Hubs;
using Hometown_Application.Controllers;

public class Program
{
    public static async Task Main(string[] args)
    {
        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        builder.Services.AddScoped<CustomValidateAntiForgeryTokenAttribute>();

        // Add DbContext (remove duplicate registration)
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
                    .SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .WithExposedHeaders("*");
            });
        });

        // Configure cookie policy to require HTTPS
        builder.Services.Configure<CookiePolicyOptions>(options =>
        {
            options.CheckConsentNeeded = context => true;
            options.MinimumSameSitePolicy = SameSiteMode.Lax;
            options.Secure = CookieSecurePolicy.Always;
        });

        // Configure Identity cookies to require HTTPS and set correct login path
        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            options.Cookie.SameSite = SameSiteMode.Lax;
            options.LoginPath = "/Identity/Account/Login"; // Fix the path
            options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
            options.SlidingExpiration = true;
        });

        builder.Services.AddHostedService<MonthlyBillGeneratorService>();

        // Add SignalR
        builder.Services.AddSignalR();
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

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseCors("AllowLocalhost");
        app.UseCookiePolicy(); // Move before UseAuthentication
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapHub<ChatHub>("/chatHub");
        app.MapHub<NotificationHub>("/notificationHub");
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

        // Seed the database, roles, and admin user
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var logger = services.GetRequiredService<ILogger<Program>>();
            try
            {
                var context = services.GetRequiredService<ApplicationDBContext>();
                logger.LogInformation("Applying database migrations...");
                await context.Database.MigrateAsync();
                logger.LogInformation("Database migrations applied successfully.");

                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                var roles = new[] { "Admin", "HomeOwner", "Staff" };
                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                    {
                        await roleManager.CreateAsync(new IdentityRole(role));
                        logger.LogInformation("Role {Role} created successfully.", role);
                    }
                }

                logger.LogInformation("Seeding admin user...");
                var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
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
                        logger.LogInformation("Admin user created and assigned to Admin role.");
                    }
                    else
                    {
                        logger.LogError("Failed to create admin user: {Errors}", string.Join(", ", result.Errors.Select(e => e.Description)));
                    }
                }

                try
                {
                    logger.LogInformation("Seeding service request data...");
                    var seeder = new ServiceRequestSeeder(context, services.GetRequiredService<ILogger<ServiceRequestSeeder>>());
                    await seeder.SeedAsync();
                    logger.LogInformation("Service request data seeded successfully.");
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred while seeding service request data.");
                    throw;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while seeding the database (roles and admin user).");
                throw;
            }
        }

        app.Run();
    }
}