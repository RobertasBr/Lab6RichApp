namespace Student_Class_Library
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public string StudentEmail { get; set; }
        
        public List<Course> Courses { get; set; } // Students can have many courses

        public Student(string studentName, int studentAge, string studentEmail)
        {
            StudentName = studentName;
            StudentAge = studentAge;
            StudentEmail = studentEmail;
        }
    }
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string DepartmentName { get; set; }
        public string LecturerName { get; set; }

        public List<Student> Students { get; set; } // Courses can have many students

        public Course(string courseName, string departmentName, string lecturerName)
        {
            CourseName = courseName;
            DepartmentName = departmentName;
            LecturerName = lecturerName;
        }
    }
}