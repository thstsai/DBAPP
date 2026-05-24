namespace UniversityManagementSystem.Models
{
    public class Takes
    {
        public string  ID        { get; set; }
        public string  course_id { get; set; }
        public string  sec_id    { get; set; }
        public string  semester  { get; set; }
        public decimal year      { get; set; }
        public string  grade     { get; set; }
    }
}
