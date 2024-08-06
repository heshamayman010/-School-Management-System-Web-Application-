using Last_version_of_school_management_system.Models.Mymodels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Last_version_of_school_management_system.Models.Mymodels
{
    public class Instructors
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }

        //[ForeignKey("deptartment_id")]
        public Departments? department { get; set; }

        [Remote("checkfordepartmentid", "Instructor", ErrorMessage = "the id of department you enterd not found ")]
        public int? deptartment_id { set; get; }
        
        //[ForeignKey("course_id")]
        public List<Courses>? course { get; set; }


        [Remote("checkforcoursid", "Instructor", ErrorMessage = "the id of course you enterd not found ")]
        public int? course_id { set; get; }



    }
}


