using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PasswordManager.Models;
using Microsoft.AspNetCore.Identity;

namespace PasswordManager
{
  class Program
  {
    static void Main(string[] args)
    {

      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      builder.Services.AddDbContext<PasswordManagerContext>(
                        dbContextOptions => dbContextOptions
                          .UseMySql(
                            builder.Configuration["ConnectionStrings:AZURE_SQL_CONNECTION"],
                            ServerVersion.AutoDetect(
                              builder.Configuration["ConnectionStrings:AZURE_SQL_CONNECTION"]
                            )
                          )
                      );

      builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                      .AddEntityFrameworkStores<PasswordManagerContext>()
                      .AddDefaultTokenProviders();

      WebApplication app = builder.Build();

      // app.UseDeveloperExceptionPage();
      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthentication();
      app.UseAuthorization();

      app.MapControllerRoute(
          name: "default",
          pattern: "{controller=Home}/{action=Index}/{id?}"
        );

      app.Run();
    }
  }
}
