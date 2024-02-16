using The_second_project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using The_second_project.Repository;
using Microsoft.AspNetCore.Authorization;

namespace first_mvc_project.Controllers
{

    // we will use the repository concept
    [Authorize]

    public class CoursesController : Controller
    {

        ICoursesRepo me;
        public CoursesController(ICoursesRepo repo )
        {
            me= repo;
        }




        public IActionResult Index()
        {
            return View();
        }


        public IActionResult gotocourses()
        {
            //var context = new Appdbcontext();
            var cours = me.Getall();

    
            return View("gotocourses",cours);


        }


        public IActionResult first()
        {

            return View("first");

        }
        public IActionResult second(Courses cours)
        {
            if (ModelState.IsValid == true)

                { 
            var context =new Appdbcontext();
            context.Courses.Add(cours);
            context.SaveChanges();
            return RedirectToAction("gotocourses","Courses");
                }
            else {
                return View("first"); }


        }
    
    // here it only must return json true or false 
    public IActionResult theRemote(int Min_degree, int Degree) { 
        
        
        if (Min_degree >Degree) {

                return Json(false);
            
            
            
            }
        else return Json(true);
        
    
        
        
        }


        public IActionResult containss(string Name)
        {
            if (Name.Contains("AAA"))
            {

                return Json(false);
            }

            else return Json(true);

        }


        public IActionResult Testajax() {
            List<Courses> courses = me.Getall();

            return View("Testajax", courses);
        
        }



        public IActionResult getstudentsbydepartments(int deptid)
        {

          
            return Json(me.Getbydepartment(deptid));

        }

        [Authorize]
        public IActionResult gg() {
            var context = new Appdbcontext();
            var lista = context.Departments.ToList();
        
        return View("theall", lista);
        }


        public IActionResult addnewcourse() {
            
            return View()
                
                
                
                ; }

        public IActionResult addnewcourse2(Courses courses)
        {
            me.Insert(courses);
            return RedirectToAction("gotocourses", "Courses");



        }

    }
    

   

}
