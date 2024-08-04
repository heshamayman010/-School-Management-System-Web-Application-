using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Last_version_of_school_management_system.Models.Mymodels
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(50, 100, ErrorMessage = "the range is between 50 and 100")]
        public int Degree { get; set; }

        [Range(minimum: 2, maximum: 100, ErrorMessage = "the range is between 2 and 100")]
        //[Remote(action: "theRemote", controller: "Courses", ErrorMessage = "the min degree must be less than the degree provided", AdditionalFields = "Degree")]
        public int Min_degree { get; set; }


        public Departments Departments { get; set; }
        //[ForeignKey("Departments")]
        public int? dept_id { get; set; }

        public Instructors Instructor { get; set; }
        public int instructor_id { get; set; }

    }
}
