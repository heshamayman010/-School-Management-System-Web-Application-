using Last_version_of_school_management_system.Repositories.IRepos;
using Microsoft.AspNetCore.Mvc;

namespace Last_version_of_school_management_system.Controllers
{
    public class CourseController : Controller
    {
        private readonly IcoursesRepo repo;

        public CourseController(IcoursesRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult getall()
        {
           var toreturn=repo.Getall();
            return View(toreturn);



        }
        public IActionResult getbyid(int id)
        {

            var toreturn = repo.Getbyid(id);
            return View(toreturn);
        }


        public IActionResult Getbydepartment(int id)
        {


            var toreturn = repo.Getbydepartment(id);
            return View(toreturn);
        }


    }
}
