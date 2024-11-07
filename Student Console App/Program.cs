using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Student_Class_Library;
using System.Reflection.Metadata;

namespace Student_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbContext dbContext = new dbContext();

            Student student1 = new Student("Igor Kups", 20, "Igorkups24@gmail.com");
            Student student2 = new Student("Alice Johnson", 22, "alice.johnson@example.com");
            Student student3 = new Student("Mark Lee", 21, "marklee123@domain.com");
            Student student4 = new Student("Sara Patel", 23, "sara.patel@domain.com");
            Student student5 = new Student("John Doe", 24, "john.doe@email.com");
            dbContext.AddRange(student1, student2, student3, student4, student5);

            Course course1 = new Course("Programming", "Computing", "Oby Islam");
            Course course2 = new Course("Data Structures", "Computer Science", "John Smith");
            Course course3 = new Course("Database Management", "Information Systems", "Sandra Lee");
            Course course4 = new Course("Operating Systems", "Computing", "Michael Carter");
            Course course5 = new Course("Software Engineering", "Engineering", "Patricia Moore");
            dbContext.AddRange(course1, course2, course3, course4, course5);

            dbContext.SaveChanges();

        }
    }
}
