using Microsoft.EntityFrameworkCore;
using SampleTest.Models;

namespace SampleTest.Data
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Foreign Key Explicit
            builder.Entity<Course>().HasOne(x => x.Department).WithMany(x => x.Courses).HasForeignKey(x => x.DepartmentID);
            /*
            builder.Entity<CourseAssignment>().HasOne(x => x.Course).WithMany(x => x.CourseAssignments).HasForeignKey(x => x.CourseID);
            builder.Entity<CourseAssignment>().HasOne(x => x.Instructor).WithMany(x => x.CourseAssignments).HasForeignKey(x => x.InstructorID);
            */
            builder.Entity<CourseAssignment>().HasKey(x => new { x.CourseID, x.InstructorID });
            builder.Entity<CourseAssignment>().HasOne(x => x.Instructor).WithMany(X => X.CourseAssignments).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<CourseAssignment>().HasOne(x => x.Course).WithMany(X => X.CourseAssignments).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Department>().HasOne(x => x.Administrator).WithMany(x => x.Departments).HasForeignKey(x => x.InstructorID);
            builder.Entity<Enrollment>().HasOne(x => x.Student).WithMany(x => x.Enrollments).HasForeignKey(x => x.StudentID);
            builder.Entity<Enrollment>().HasOne(x => x.Course).WithMany(x => x.Enrollments).HasForeignKey(x => x.CourseID);
            builder.Entity<OfficeAssignment>().HasOne(x => x.Instructor).WithOne(x => x.OfficeAssignment);
        }

    }
}
