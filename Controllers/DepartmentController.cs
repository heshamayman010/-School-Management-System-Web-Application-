using Last_version_of_school_management_system.Models.Mymodels;
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



       public IActionResult forgetbyid()
        {

            return View();
        }

        public IActionResult getbyid(int id)
        {

            var toreturn = repo.Getbyid(id);
            return View(toreturn);
        }



        // delete - edit - add 

        [HttpGet]
        public IActionResult Adddepartment()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Adddepartment(Departments departmenttoadd)
        {

            if (ModelState.IsValid)
            {
                repo.Add(departmenttoadd);
                return RedirectToAction("getall");
            }
            else
            {

                return View();
            }
        }


        [HttpGet]
        public IActionResult delete()
        {

            return View();

        }
        [HttpPost]
        public IActionResult delete(int id)
        {

            var deletedornot = repo.Delete(id);

            // to check if it could delete the department 
            if (deletedornot)
            {

                return RedirectToAction("getall");
            }
            else
            {

                return View();

            }

        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();

        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Edit(int id, Departments department)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            else
            {

                repo.Edit(id, department);
                return RedirectToAction("getall");


            }

        }





    }
}

