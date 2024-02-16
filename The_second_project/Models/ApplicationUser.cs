using Microsoft.AspNetCore.Identity;

namespace The_second_project.Models
{
    public class ApplicationUser:IdentityUser
    {

        // this will be the intermediate between the useridenty which is the model of users and between the 


        // app user ------ IdentityUser(Model)--------usermanger(serviceproviders)---------userstore(Repository)---------database 
        public string  Address { get; set; }

    }
}
