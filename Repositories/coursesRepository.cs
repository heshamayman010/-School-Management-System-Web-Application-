using Last_version_of_school_management_system.Models.Mymodels;
using Last_version_of_school_management_system.Repositories.IRepos;

namespace Last_version_of_school_management_system.Repositories
{
    public class coursesRepository : IcoursesRepo
    {
        private readonly AppDbcontext context;

        public coursesRepository(AppDbcontext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            if (id != 0)
            {
               var coursetobedeleted= context.Courses.FirstOrDefault(x => x.Id == id);

                if (coursetobedeleted != null)
                {

                    context.Courses.Remove(coursetobedeleted);
                    context.SaveChanges();
                    return true;
                }
                else
                {

                    return false;
                }


            }
            return false;

        }

        public void Edit(int id, Courses courses)
        {

            var oldone = context.Courses.FirstOrDefault(x => x.Id == id);
            if (oldone != null)
            {

                oldone.dept_id = courses.dept_id;
                oldone.Min_degree = courses.Min_degree;
                oldone.Degree = courses.Degree;
                oldone.Name = courses.Name;
                context.SaveChanges();
            }

        }

        public List<Courses> Getall()
        {

            var toreturn = context.Courses.ToList();
            return toreturn;

        }

        public List<Courses> Getbydepartment(int dept_id)
        {
        var toreturn=context.Courses.Where(x=>x.dept_id == dept_id).ToList();
            return toreturn;
        }

        public Courses Getbyid(int id)
        {
            
            
            var coursetoreturn = context.Courses.FirstOrDefault(x=>x.Id == id);
                return coursetoreturn;


        }

        public void Add(Courses coursetobeadded)
        {
            context.Courses.Add(coursetobeadded);
            context.SaveChanges();

        }
    }
}
