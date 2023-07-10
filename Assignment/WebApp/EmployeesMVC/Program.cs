using EmployeesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesMVC
{
   
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<EmployeesMvcEntityFwContext>(options =>
                      options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeesMvcEntityFwContext")));

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
                pattern: "{controller=EmpDatums}/{action=Index}/{id?}");

            app.Run();
        }
    }
}