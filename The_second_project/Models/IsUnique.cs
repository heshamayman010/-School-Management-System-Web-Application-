using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;

namespace The_second_project.Models
{
    public class UniqueNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            // here the value of the validationContext will be the object of courses that i am using 

            if (value == null)
                return null;

            string newname = value.ToString();
            var context = new Appdbcontext();

            Courses cours = context.Courses.FirstOrDefault(s => s.Name == newname);

             Courses co = (Courses)validationContext.ObjectInstance;
            if (cours != null)
            {
                return new ValidationResult("Name Must Be Unique");
            }
            return ValidationResult.Success;
        }




    }
    }

//string newName = value.ToString();
////Student stdForm = (Student)validationContext.ObjectInstance;
//if (stddb != null)
//{
//    return new ValidationResult("Name Must Be Unique");
//}
//return ValidationResult.Success;
//        }