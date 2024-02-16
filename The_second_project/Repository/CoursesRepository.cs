using System.Collections.Generic;
using System.Linq;
using The_second_project.Models;

namespace The_second_project.Repository
{
    public class CoursesRepository : ICoursesRepo
    {
        Appdbcontext context;
        public CoursesRepository(Appdbcontext _context)
        {
            context = _context;
        }

        // here is the proper way to clarify it 
        public void Delete(int id)
        {
            var tobedeleted=context.Courses.First(x=>x.Id==id);
            context.Remove(tobedeleted);
            context.SaveChanges();
        }

        public void Edit(int id, Courses courses)
        {

            var old = context.Courses.First(x=>x.Id==id);
            old.dept_id=courses.dept_id;
            old.Degree = courses.Degree; old.Name=courses.Name;
            old.Min_degree = courses.Min_degree;

            context.SaveChanges();

        }

        public List<Courses> Getall()
        {
            
            return context.Courses.ToList();

        }

        public List<Courses> Getbydepartment(int dept_id)
        {
            return context.Courses.Where(x=>x.dept_id==dept_id).ToList();
        }

        public Courses Getbyid(int id)
        {

            return context.Courses.FirstOrDefault(x => x.Id == id);
        }

        public void Insert( Courses coursetobeadded)

        {

            context.Courses.Add(coursetobeadded);
            context.SaveChanges();

        }
    }
}
