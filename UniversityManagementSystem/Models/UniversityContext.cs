using System.Data.Entity;

namespace UniversityManagementSystem.Models
{
    public class UniversityEntities : DbContext
    {
        public UniversityEntities() : base("name=UniversityEntities") { }

        public DbSet<User>       user       { get; set; }
        public DbSet<Student>    student    { get; set; }
        public DbSet<Instructor> instructor { get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<Course>     course     { get; set; }
        public DbSet<Section>    section    { get; set; }
        public DbSet<Takes>      takes      { get; set; }
        public DbSet<Teaches>    teaches    { get; set; }
        public DbSet<Advisor>    advisor    { get; set; }
        public DbSet<TimeSlot>   time_slot  { get; set; }
        public DbSet<Prereq>     prereq     { get; set; }
        public DbSet<Classroom>  classroom  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()      .ToTable("user");
            modelBuilder.Entity<Student>()   .ToTable("student");
            modelBuilder.Entity<Instructor>().ToTable("instructor");
            modelBuilder.Entity<Department>().ToTable("department");
            modelBuilder.Entity<Course>()    .ToTable("course");
            modelBuilder.Entity<Section>()   .ToTable("section");
            modelBuilder.Entity<Takes>()     .ToTable("takes");
            modelBuilder.Entity<Teaches>()   .ToTable("teaches");
            modelBuilder.Entity<Advisor>()   .ToTable("advisor");
            modelBuilder.Entity<TimeSlot>()  .ToTable("time_slot");
            modelBuilder.Entity<Prereq>()    .ToTable("prereq");
            modelBuilder.Entity<Classroom>() .ToTable("classroom");

            // Composite primary keys
            modelBuilder.Entity<Classroom>()
                .HasKey(e => new { e.building, e.room_number });

            modelBuilder.Entity<Section>()
                .HasKey(e => new { e.course_id, e.sec_id, e.semester, e.year });

            modelBuilder.Entity<Takes>()
                .HasKey(e => new { e.ID, e.course_id, e.sec_id, e.semester, e.year });

            modelBuilder.Entity<Teaches>()
                .HasKey(e => new { e.ID, e.course_id, e.sec_id, e.semester, e.year });

            modelBuilder.Entity<TimeSlot>()
                .HasKey(e => new { e.time_slot_id, e.day, e.start_hr, e.start_min });

            modelBuilder.Entity<Prereq>()
                .HasKey(e => new { e.course_id, e.prereq_id });
        }
    }
}
