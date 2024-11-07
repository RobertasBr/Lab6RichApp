using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Student_Class_Library;  // Ensure the correct namespace for Student and Course
using System;
using System.Linq;

namespace Student_MVC
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<RazorDB>();

            if (context == null || context.Students == null || context.Courses == null)
            {
                throw new ArgumentNullException("Null RazorDB context or DbSet");
            }

            if (context.Students.Any() || context.Courses.Any())
            {
                return;
            }

            context.Students.AddRange(
                new Student("Igor Kups", 20, "Igorkups24@gmail.com"),
                new Student("Alice Johnson", 22, "alice.johnson@example.com")
            );

            context.Courses.AddRange(
                new Course("Programming", "Computing", "Oby Islam"),
                new Course("Data Structures", "Computer Science", "John Smith")
            );

            context.SaveChanges();
        }
    }
}
