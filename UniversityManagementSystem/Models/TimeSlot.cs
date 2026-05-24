namespace UniversityManagementSystem.Models
{
    public class TimeSlot
    {
        public string  time_slot_id { get; set; }
        public string  day          { get; set; }
        public decimal start_hr     { get; set; }
        public decimal start_min    { get; set; }
        public decimal end_hr       { get; set; }
        public decimal end_min      { get; set; }
    }
}
