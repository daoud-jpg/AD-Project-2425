using ConcertTickets.Data;
using ConcertTickets.Repositories;
using ConcertTickets.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ConcertTickets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<CustomUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddControllersWithViews();
            
            // Services
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped<IConcertRepository, ConcertRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IConcertService, ConcertService>();
            builder.Services.AddScoped<ITicketOfferService, TicketOfferService>();
            builder.Services.AddScoped<ITicketOfferRepository, TicketOfferRepository>();


            var app = builder.Build();

            SeedClaimsAsync(app.Services).GetAwaiter().GetResult();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Concert}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();

            static async Task SeedClaimsAsync(IServiceProvider serviceProvider)
            {
                const string ADMIN_ACCOUNT = "admin@test.be";
                const string ADMIN_PASSWORD = "Admin@123";
                using var scope = serviceProvider.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Data.CustomUser>>();

            var user = await userManager.FindByEmailAsync(ADMIN_ACCOUNT);
            if (user == null)
            {
                    // Optioneel: maak een standaardgebruiker aan als die niet bestaat
                    user = new Data.CustomUser
                    {
                        FirstName = "Admin",
                        LastName = "User",
                        Email = ADMIN_ACCOUNT,
                        UserName = ADMIN_ACCOUNT,
                        MemberCardNumber = "ODI012789",
                        EmailConfirmed = true
                    };
                await userManager.CreateAsync(user, ADMIN_PASSWORD); // Standaard wachtwoord
            }

            // Voeg claims toe aan de gebruiker
            var claims = new[]
            {
                new Claim("IsAdmin", "true"),
            };

            foreach (var claim in claims)
            {
                if (!(await userManager.GetClaimsAsync(user)).Any(c => c.Type == claim.Type))
                {
                    await userManager.AddClaimAsync(user, claim);
                }
            }
        }
    }
    }
}
