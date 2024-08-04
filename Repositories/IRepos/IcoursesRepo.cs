using Last_version_of_school_management_system.Models.Mymodels;

namespace Last_version_of_school_management_system.Repositories.IRepos
{
    public interface IcoursesRepo
    {

        List<Courses> Getall();
        Courses Getbyid(int id);
        //return Json(context.Courses.Where(x=>x.dept_id== deptid));
        List<Courses> Getbydepartment(int dept_id);
        // here we will use all the properties in this course to be the old one properties
        void Edit(int id, Courses courses);
        bool Delete(int id);
        void Add(Courses coursetobeadded);



    }
}
