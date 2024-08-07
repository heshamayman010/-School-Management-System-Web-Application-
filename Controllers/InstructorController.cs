﻿using Last_version_of_school_management_system.Models.Mymodels;
using Last_version_of_school_management_system.Repositories.IRepos;
using Microsoft.AspNetCore.Mvc;

namespace Last_version_of_school_management_system.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IRepoInstructor repo;
        private readonly AppDbcontext context;

        public InstructorController(IRepoInstructor repo,AppDbcontext context)
        {
            this.repo = repo;
            this.context = context;
        }


        public IActionResult getall()
        {
            var toreturn = repo.Getall();
            return View(toreturn);



        }


        public IActionResult getbyid(int id)
        {

            var toreturn=repo.getbyid(id);
            return View(toreturn);
        }

        public IActionResult forgetbyid()
        {

            return View("Forthinputid");
        }


        public IActionResult Getbydepartment(int id)
        {


            var toreturn= repo.getbydepartment(id);

            ViewBag.theid = id;
            return View(toreturn);
        }


        public IActionResult forgetbudepartment()
        {

            return View();
        }

        public IActionResult getbyname(string name)
        {

            var toretun=repo.getbyname(name);
            return View(toretun);
        }

        public IActionResult forgetbyname()
        {

            return View();
        }


        // to open the view 
        [HttpGet]
        public IActionResult Edit()

        {
            return View();

        }

        // to apply the edit 
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Edit(int id,Instructors instructor)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            else
            {

                repo.Editoneinstructor(id, instructor);
                return RedirectToAction("getall");


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

         var deletedornot=   repo.Deleteoneinstructor(id);

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
        public IActionResult addnew()
        {

            return View();

        }

        [HttpPost]
        public IActionResult addnew(Instructors instrucortoadd)
        {
            if (ModelState.IsValid)
            {
                repo.Addnew(instrucortoadd);
                return RedirectToAction("getall");
            }
            else
            {

                return View();
            }
        }






        public IActionResult checkfordepartmentid(int deptartment_id)
        {

            var found = context.Departments.FirstOrDefault(x => x.Id == deptartment_id);

            if (found == null)
            {
                return Json(false);
            }
            else
            {

                return Json(true);
            }

        }




        public IActionResult checkforcoursid(int coursid_id)
        {

            var found=context.Courses.FirstOrDefault(x=>x.Id == coursid_id);

            if(found == null)
            {
                return Json(false);
            }
            else
            {
                return Json(true);
            }
        }

    }
}




