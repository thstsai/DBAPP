namespace UniversityManagementSystem.Models
{
    public class Section
    {
        public string  course_id    { get; set; }
        public string  sec_id       { get; set; }
        public string  semester     { get; set; }
        public decimal year         { get; set; }
        public string  building     { get; set; }
        public string  room_number  { get; set; }
        public string  time_slot_id { get; set; }
    }
}
