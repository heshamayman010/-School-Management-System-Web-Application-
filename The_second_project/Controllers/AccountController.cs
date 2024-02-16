using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using The_second_project.Models;

namespace The_second_project.Controllers
{
    public class AccountController : Controller
    {



        public AccountController(UserManager<ApplicationUser> mang,SignInManager<ApplicationUser> sig)
        {
            usermang = mang;
            signmang = sig;
        }

        public UserManager<ApplicationUser> usermang { get; }
        public SignInManager<ApplicationUser> signmang { get; }

        [HttpGet]
        public IActionResult Register() { 
        
        
        return View();
        }



        [HttpPost]
        public async Task < IActionResult> Register(RegisterUserviewModel register) {
            if (ModelState.IsValid)
            {
                ApplicationUser app = new ApplicationUser();
                app.UserName = register.UserName;
                app.PasswordHash = register.password;

          IdentityResult result =   await usermang.CreateAsync(app, register.password);

                if (result.Succeeded == true) {

                    // we must give it the cookies 

                    await signmang.SignInAsync(app, false);

                
                return RedirectToAction("Index","Home");
                
                }

                else
                {

                    // here we must send all the error messages 


                    foreach (var item in result.Errors)
                    {

                        ModelState.AddModelError(" ",item.Description);

                    }

                }
            }


            return View(register);
        }
        public async Task <IActionResult> Logout()
        {
            await signmang.SignOutAsync();
            return RedirectToAction("Register", "Account");


        }

        [HttpGet]
        public IActionResult Signin()
        {

            return View();


        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Signin(Loginviewmodel model)
        {

            if (ModelState.IsValid)
            {

                ApplicationUser therequireduser=  await usermang.FindByNameAsync(model.username);

                // here we first check if the email found 
                if (therequireduser != null)
                {

                    // then we check if the password is correct 
                    bool isthere = await usermang.CheckPasswordAsync(therequireduser, model.pasaword);

                    if (isthere == true)
                    {
                        // if its correct we then give it the cookie to go to the website 
                        // now i add the claims to be added to the cookies when tried to sign in 
                        //var claimss=new List<Claim>();
                        //claimss.Add(new Claim("Address", User.Identity.Name));
                        //await signmang.SignInWithClaimsAsync(therequireduser, model.rememberme, claimss);

                        await signmang.SignInAsync(therequireduser, model.rememberme);
                        return RedirectToAction("Index", "Home");

                    }
                    else
                    {
                        ModelState.AddModelError("the user is not found", "the user is not found");
                    }


                } else { }

            }


            return View(model);


        }

        [HttpGet]
        [Authorize(Roles = "Admin")]

        public IActionResult addadmin() {

            return View();
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task < IActionResult> addadmin(RegisterUserviewModel user) {
                if (ModelState.IsValid)
                {
                    ApplicationUser app = new ApplicationUser();
                    app.UserName = user.UserName;
                    app.PasswordHash = user.password;

                    IdentityResult result = await usermang.CreateAsync(app, user.password);

                await usermang.AddToRoleAsync(app, "Admin");

                    if (result.Succeeded == true)
                    {

                        // we must give it the cookies 

                        await signmang.SignInAsync(app, false);


                        return RedirectToAction("Index", "Home");

                    }

                    else
                    {

                        // here we must send all the error messages 


                        foreach (var item in result.Errors)
                        {

                            ModelState.AddModelError(" ", item.Description);

                        }

                    }
                }


                return View(user);
            }

        }
    }
