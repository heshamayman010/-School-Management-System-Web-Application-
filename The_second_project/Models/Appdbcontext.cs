using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace The_second_project.Models
{

    // this will make it able to be used with the tables of the login in the same database 

    // if we dont it will be alone and each table will be in different databases
    public class Appdbcontext:IdentityDbContext<ApplicationUser>
    {

        public Appdbcontext()
        {
            
        }
        public Appdbcontext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // to use the appsetting constr

            

            // this is used to build the configuration with the server 
            optionsBuilder.UseSqlServer("Server = .\\SQLEXPRESS; Database = The_second_project_data ; Integrated Security = SSPI; TrustServerCertificate = True;");
        }


        public DbSet<Courses> Courses { get; set; }
        public DbSet<Instructors> Instructors { get; set; } 
        public DbSet<Trainees> Trainees { get; set; }

        public DbSet<Departments> Departments { get; set; }
        public DbSet<Accounts> Accounts { get; set; }


    }
}
