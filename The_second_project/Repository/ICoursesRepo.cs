using System.Collections.Generic;
using The_second_project.Models;

namespace The_second_project.Repository
{
    public interface ICoursesRepo
    {
        // crud


        List<Courses> Getall();
        Courses Getbyid(int id);
          //return Json(context.Courses.Where(x=>x.dept_id== deptid));
        List<Courses> Getbydepartment(int dept_id);
        // here we will use all the properties in this course to be the old one properties
        void Edit(int id , Courses courses);
        void Delete(int id);
        void Insert (Courses coursetobeadded);



    }
}
