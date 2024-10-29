using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MvcCodeFirstApproach.Models;

namespace MvcCodeFirstApproach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var Connstr = builder.Configuration.GetConnectionString("Constr");
            builder.Services.AddDbContext<EmployeeDBContext>(options=>options.UseSqlServer(Connstr));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=EmployeeModel}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
