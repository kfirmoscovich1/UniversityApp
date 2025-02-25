using System.Collections.Generic;

namespace UniversityApp
{
    public class Department
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public List<Major> Majors { get; set; }

        public Department(string name)
        {
            Name = name;
            Courses = new List<Course>();
            Majors = new List<Major>();
        }

        public void AddCourse(Course course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
            }
        }

        public void AddMajor(Major major)
        {
            if (!Majors.Contains(major))
            {
                Majors.Add(major);
            }
        }
    }
}
