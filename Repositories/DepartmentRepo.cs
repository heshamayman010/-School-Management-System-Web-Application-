using Last_version_of_school_management_system.Models.Mymodels;
using Last_version_of_school_management_system.Repositories.IRepos;

namespace Last_version_of_school_management_system.Repositories
{
    public class DepartmentRepo : IdepartmentsRepo
    {
        private readonly AppDbcontext context;

        public DepartmentRepo(AppDbcontext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            if (id != 0)
            {
                var tobedeleted = context.Departments.FirstOrDefault(x => x.Id == id);

                if (tobedeleted != null)
                {

                    context.Departments.Remove(tobedeleted);
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

        public void Edit(int id, Departments department)
        {
            var oldone=context.Departments.FirstOrDefault(x=>x.Id == id);

            if (oldone != null)
            {

                oldone.Manger=department.Manger;
                oldone.Name=department.Name;
                context.SaveChanges();
            }
        }

        public List<Departments> Getall()
        {
            var toreturn = context.Departments.ToList();
            return toreturn;
        }

        public Departments Getbyid(int id)
        {

            var toreturn = context.Departments.FirstOrDefault(x => x.Id == id);
            return toreturn;

        }

        public void Add(Departments departmenttoadd)
        {

            context.Departments.Add(departmenttoadd);
            context.SaveChanges();
        }
    }
}
