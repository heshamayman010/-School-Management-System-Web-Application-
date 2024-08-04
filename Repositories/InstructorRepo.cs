using Last_version_of_school_management_system.Models.Mymodels;
using Last_version_of_school_management_system.Repositories.IRepos;

namespace Last_version_of_school_management_system.Repositories
{
    public class InstructorRepo : IRepoInstructor
    {
        private readonly AppDbcontext context;

        public InstructorRepo(AppDbcontext context)
        {
            this.context = context;
        }

        public void Addnew(Instructors instructor)
        {

           context.Instructors.Add(instructor);
            context.SaveChanges();


        }

        public bool Deleteoneinstructor(int id)
        {

            if (id != 0)
            {
                var tobedeleted = context.Instructors.FirstOrDefault(x => x.Id == id);

                if (tobedeleted != null)
                {

                    context.Instructors.Remove(tobedeleted);
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

        public void Editoneinstructor(int id, Instructors instructor)
        {
                var oldone=context.Instructors.FirstOrDefault(x=>x.Id== id);

            if (oldone != null)
            {

                oldone.Address = instructor.Address;
                oldone.deptartment_id = instructor.deptartment_id;
                oldone.course_id = instructor.course_id;
                oldone.Image = instructor.Image;
                oldone.Name = instructor.Name;
                oldone.Salary = instructor.Salary;
                context.SaveChanges();
            }

        }

        public List<Instructors> Getall()
        {
            var toreturn=context.Instructors.ToList();
            return toreturn;
        }

        public List<Instructors> getbydepartment(int deptId)
        {
            var toreturn = context.Instructors.Where(x => x.deptartment_id == deptId).ToList();
            
            return toreturn;
        }

        public Instructors getbyid(int id)
        {
            var toreturn = context.Instructors.FirstOrDefault(x => x.Id == id);
            return toreturn;

        }

        public Instructors getbyname(string name)
        {
                var toreturn=context.Instructors.FirstOrDefault(x=>x.Name==name);

            return toreturn;
        }
    }
}
