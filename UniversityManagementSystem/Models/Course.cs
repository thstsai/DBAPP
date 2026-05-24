using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Course
    {
        [Key]
        public string  course_id { get; set; }
        public string  title     { get; set; }
        public string  dept_name { get; set; }
        public decimal? credits  { get; set; }
    }
}
