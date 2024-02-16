using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace The_second_project.Controllers
{
    public class UploadController : Controller
    {
        private readonly IWebHostEnvironment host;

        public UploadController(IWebHostEnvironment host)
        {
            this.host = host;
        }

        [HttpGet]
        public IActionResult Upload()
        {

            return View();

        }

        [HttpPost]
        public IActionResult Upload(IFormFile image)
        {
            string mypath = Path.Combine(host.WebRootPath, "Images");

           
            // the unique file name 
            string uniquename=Guid.NewGuid().ToString()+"_"+image.FileName;

            string thefullname=Path.Combine(mypath, uniquename);
            string allowedExtensions = ".jpg,.jpeg,.png";
            string fileExtension = Path.GetExtension(image.FileName).ToLowerInvariant();

            if (!allowedExtensions.Split(',').Contains(fileExtension))
            {
                return Content("not allowed image type");

            }

            using (FileStream fs = new FileStream(thefullname, FileMode.Create)) { 
            
            
            image.CopyTo(fs);
                fs.Close();
            
            
            }

            return Content("the image is uploaded ");

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult photo() { 
        return View();
        
        }
        [HttpPost]

        // here i gave it the parameter name image so when i create the view that take the input i must give it the same name to make the 
        // model binder be able to detect it and map it to the same one 
        public IActionResult photo(IFormFile image)
        {
            string path=Path.Combine(host.WebRootPath, image.FileName);
            string uniquename=Path.Combine(Guid.NewGuid().ToString(),path);

            using (FileStream fs = new FileStream(uniquename, FileMode.Create)) {

                image.CopyTo(fs);
                fs.Close();
            }


            return Content("image is uploaded successfully");
        }



    }

}
