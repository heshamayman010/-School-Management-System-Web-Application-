using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using The_second_project.Models;

namespace The_second_project.Controllers
{//[authorize]  it will only check if he has cookies or not that means he is signed in or not

   // [Authorize(Roles ="Admin")]


    public class RolleController : Controller
    {

        public RolleController(RoleManager<IdentityRole> role)
        {
            Role = role;
        }

        public RoleManager<IdentityRole> Role { get; }

        [HttpGet]
        public IActionResult neww (){

            return View();

}
        [HttpPost]
        public async Task <IActionResult> neww(Roleviewmodel rolevm)
        {
            if (ModelState.IsValid)
            {
  
                IdentityRole identity = new IdentityRole();

                identity.Name = rolevm.Rollename;
               var result=await Role.CreateAsync(identity);

                if (result.Succeeded)
                {


                    return View(rolevm);
                }

                foreach(var item in result.Errors)
                {

                    ModelState.AddModelError("", item.Description);
                }
            }


            return View();

        }




    }
}
