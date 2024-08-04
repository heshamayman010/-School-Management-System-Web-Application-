using Last_version_of_school_management_system.Repositories.IRepos;
using Microsoft.AspNetCore.Mvc;

namespace Last_version_of_school_management_system.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IdepartmentsRepo repo;

        public DepartmentController(IdepartmentsRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult getall()
        {
            var toreturn = repo.Getall();
            return View(toreturn);



        }


        public IActionResult getbyid(int id)
        {

            var toreturn = repo.Getbyid(id);
            return View(toreturn);
        }


    }
}
