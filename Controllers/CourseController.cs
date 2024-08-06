using Last_version_of_school_management_system.Models.Mymodels;
using Last_version_of_school_management_system.Repositories.IRepos;
using Microsoft.AspNetCore.Mvc;

namespace Last_version_of_school_management_system.Controllers
{
    public class CourseController : Controller
    {
        private readonly IcoursesRepo repo;
        private readonly AppDbcontext context;

        public CourseController(IcoursesRepo repo,AppDbcontext context)
        {
            this.repo = repo;
            this.context = context;
        }



        public IActionResult getall()
        {
           var toreturn=repo.Getall();
            return View(toreturn);



        }

        [HttpGet]
        public IActionResult forgetbyid()
        {
            return View();
        }


        [HttpPost]
        public IActionResult getbyid(int id)
        {

            var toreturn = repo.Getbyid(id);
            return View(toreturn);
        }



        public IActionResult forgetbydepartmetn()
        {

            return View();
        }


        public IActionResult Getbydepartment(int id)
        {


            var toreturn = repo.Getbydepartment(id);
            return View(toreturn);
        }

        [HttpGet]
        public IActionResult Add()
        {


            return View();
        }


        [HttpPost]
        public IActionResult Add(Courses coursetoadd)
        {
            
            if(ModelState.IsValid)
            {

                repo.Add(coursetoadd);

                return RedirectToAction("getall");
            }
            else {
            
                return View(); 
            
            
            }
        }



        public IActionResult checkfordepartmentid(int deptid)
        {

            var founddepartment=context.Departments.FirstOrDefault(x=>x.Id==deptid);
            if (founddepartment == null)
            {

                return Json(false);
            }


            return Json(true);

        }


        public IActionResult CheckforinstructorId(int instructorid)
        {

            var found = context.Instructors.FirstOrDefault(x => x.Id == instructorid);
            if (found == null)
            {

                return Json(false);
            }


            return Json(true);

        }





    }
}
