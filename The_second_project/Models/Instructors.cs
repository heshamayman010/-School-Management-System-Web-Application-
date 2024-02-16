using System.ComponentModel.DataAnnotations.Schema;

namespace The_second_project.Models
{
    public class Instructors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public Departments department { get; set; }
        [ForeignKey("department")]
        public int dept_id{set;get;}
        public Accounts account { get; set; }
        public Courses course { get; set; }
        [ForeignKey("course")]
        public int crs_id { set;get;}
    }
}
