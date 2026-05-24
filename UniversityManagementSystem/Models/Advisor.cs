using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Advisor
    {
        [Key]
        public string s_ID { get; set; }
        public string i_ID { get; set; }
    }
}
