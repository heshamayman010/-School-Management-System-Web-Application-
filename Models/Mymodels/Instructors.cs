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

        public int? deptartment_id { set; get; }
        
        //[ForeignKey("course_id")]
        public List<Courses>? course { get; set; }


        public int course_id { set; get; }



    }
}
