using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Department
    {
        [Key]
        public string  dept_name { get; set; }
        public string  building  { get; set; }
        public decimal? budget   { get; set; }
    }
}
