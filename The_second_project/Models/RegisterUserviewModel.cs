using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace The_second_project.Models
{
    public class RegisterUserviewModel : IdentityUser
    {

        [Required]
        [MaxLength(50)]
        public string username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }




        [Required]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirmpassword { get; set; }






    }
}
