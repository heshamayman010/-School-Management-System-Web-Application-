using Last_version_of_school_management_system.Models.Mymodels;

namespace Last_version_of_school_management_system.Repositories.IRepos
{
    public interface IdepartmentsRepo
    {

        List<Departments> Getall();
        Departments Getbyid(int id);
        void Edit(int id, Departments department);
        bool Delete(int id);
        void Add(Departments departmenttoadd);


    }
}
