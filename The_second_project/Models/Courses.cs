using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace The_second_project.Models
{
    public class Courses
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="this field is required ")]
        [MaxLength(50,ErrorMessage ="you cant enter over than 50 char")]
        [UniqueName]
        [Remote(action:"containss",controller:"Courses",ErrorMessage ="the name cant contain AAA")]
        public string Name { get; set; }
        
        [Range(10,100,ErrorMessage ="the range is between 10 and 100")]
        public int Degree { get; set; }
        
        [Range(minimum:2,maximum:100,ErrorMessage ="the range is between 2 and 100")]
        [Remote(action:"theRemote",controller:"Courses",ErrorMessage ="the min degree must be less than the degree provided",AdditionalFields ="Degree")]
        public int Min_degree { get; set; }
        [Required]
        public int dept_id { get; set; }
    }
}
