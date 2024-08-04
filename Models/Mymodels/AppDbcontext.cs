using Microsoft.EntityFrameworkCore;

namespace Last_version_of_school_management_system.Models.Mymodels
{
    public class AppDbcontext:DbContext
    {


        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Departments> Departments { get; set; }


        public AppDbcontext()
        {
            
        }
        public AppDbcontext(DbContextOptions options):base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Instructors>().HasOne(x=>x.department).WithOne(x=>x.courses)

            modelBuilder.Entity<Instructors>().HasOne(x => x.department).WithMany(x => x.instructor).HasForeignKey(x => x.deptartment_id).OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Courses>().HasOne(x => x.Instructor).WithMany(x => x.course).HasForeignKey(x => x.instructor_id).OnDelete(DeleteBehavior.ClientSetNull);




            modelBuilder.Entity<Courses>().HasOne(x => x.Departments).WithMany(x => x.courses).HasForeignKey(x => x.dept_id).OnDelete(DeleteBehavior.ClientSetNull);



            base.OnModelCreating(modelBuilder);
        }

    }
}
