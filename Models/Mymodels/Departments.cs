using System.ComponentModel.DataAnnotations.Schema;

namespace Last_version_of_school_management_system.Models.Mymodels
{
    public class Departments
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Manger { get; set; }

        public List<Instructors>? instructor { get; set; }

        public List<Courses>? courses { get; set; }

    }
}
