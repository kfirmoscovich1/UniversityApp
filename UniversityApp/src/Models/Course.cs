using System.Collections.Generic;

namespace UniversityApp
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string InstructorID { get; set; }
        public string InstructorName { get; set; }
        public List<string> Students { get; set; }
        public List<Schedule> Schedule { get; set; }
        public string DepartmentName { get; set; }

        public Course(string courseID, string courseName, string instructorID, string instructorName, string departmentName, List<string> students = null, List<Schedule> schedule = null)
        {
            CourseID = courseID;
            CourseName = courseName;
            InstructorID = instructorID;
            InstructorName = instructorName;
            DepartmentName = departmentName;
            Students = students ?? new List<string>();
            Schedule = schedule ?? new List<Schedule>();
        }
    }

    public class Schedule
    {
        public string Day { get; set; }
        public string Time { get; set; }

        public Schedule(string day, string time)
        {
            Day = day;
            Time = time;
        }
    }
}
