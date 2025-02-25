using System.Collections.Generic;

namespace UniversityApp
{
    public class Major
    {
        public string Name { get; set; }
        public List<string> RequiredCourses { get; set; }  
        public Department Department { get; set; }

        public Major(string name, Department department)
        {
            Name = name;
            RequiredCourses = new List<string>();
            Department = department;
        }

        public void AddCourse(string courseId)  
        {
            if (!RequiredCourses.Contains(courseId))
            {
                RequiredCourses.Add(courseId);
            }
        }
    }
}
