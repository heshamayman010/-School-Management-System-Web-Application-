using Last_version_of_school_management_system.Models.Mymodels;

namespace Last_version_of_school_management_system.Repositories.IRepos
{
    public interface IRepoInstructor
    {

        List<Instructors> Getall();


        Instructors getbyid(int id);
        Instructors getbyname(string name);

        List<Instructors> getbydepartment(int deptId);

        void Editoneinstructor(int id, Instructors instructor);
        bool Deleteoneinstructor(int id);
        void Addnew(Instructors instructor);





    }
}
