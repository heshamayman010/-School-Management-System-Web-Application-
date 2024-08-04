using Last_version_of_school_management_system.Models.Mymodels;
using Last_version_of_school_management_system.Repositories;
using Last_version_of_school_management_system.Repositories.IRepos;
using Microsoft.EntityFrameworkCore;

namespace Last_version_of_school_management_system
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<AppDbcontext>(
                opttions =>
                {

                    opttions.UseSqlServer("Server = .\\SQLEXPRESS; Database = Last version of school ; Integrated Security = SSPI; TrustServerCertificate = True;");
                }
                );

            builder.Services.AddScoped<IcoursesRepo, coursesRepository>();
            builder.Services.AddScoped<IRepoInstructor, InstructorRepo>();
            builder.Services.AddScoped<IdepartmentsRepo,DepartmentRepo>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}