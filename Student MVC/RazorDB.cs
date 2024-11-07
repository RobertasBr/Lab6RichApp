using Microsoft.EntityFrameworkCore;
using Student_Class_Library;

namespace Student_MVC
{
    public class RazorDB : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public RazorDB(DbContextOptions<RazorDB> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.StudentName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Student>()
                .Property(s => s.StudentEmail)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Student>()
                .HasIndex(s => s.StudentEmail)
                .IsUnique();

            modelBuilder.Entity<Student>()
                .Property(s => s.StudentAge)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .Property(c => c.CourseName)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Course>()
                .Property(c => c.DepartmentName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Course>()
                .Property(c => c.LecturerName)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
