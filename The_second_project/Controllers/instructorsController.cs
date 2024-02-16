using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using The_second_project.Models;

namespace The_second_project.Controllers
{
    public class instructorsController : Controller
    {

        // first i want one to return all the instructors in the database
        [ValidateAntiForgeryToken]
        public IActionResult getall()
        {

            var context=new Appdbcontext();

            var inst=context.Instructors.ToList();
            return View("getall", inst);


        }
        public IActionResult signin()
        {
            var context = new Appdbcontext();
            ViewBag.departments = context.Departments.ToList();


            return View("signin");


        }

        [ValidateAntiForgeryToken]
        public IActionResult infosignin(Instructors instra) {



        var context=new Appdbcontext();

            instra.crs_id = 1;
            context.Instructors.Add(instra);
            context.SaveChanges();
            return RedirectToAction("getall", "instructors");
        
        }
        public IActionResult signin2()
        {


            return View("signin2");


        }


        public IActionResult infosignin2(Instructors instra)
        {

            var context = new Appdbcontext();
            instra.dept_id = 2;
            instra.crs_id = 1;
            context.Instructors.Add(instra);
            context.SaveChanges();
            return RedirectToAction("getall", "instructors");

        }
    }
}
