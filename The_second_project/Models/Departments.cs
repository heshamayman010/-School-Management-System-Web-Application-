using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_second_project.Models
{
    public class Departments
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Manger { get; set; }
        public List<Instructors> instructor { get; set; }
    }
}
