using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Instructor
    {
        [Key]
        public string  ID        { get; set; }
        public string  name      { get; set; }
        public string  dept_name { get; set; }
        public decimal? salary   { get; set; }
    }
}
