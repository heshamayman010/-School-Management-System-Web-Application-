namespace The_second_project.Models
{
    public class Trainees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; } 
        public int Grade { get; set; }

        public int dept_id { get; set; }
    }
}