using System.Collections.Generic;

namespace UniversityApp.Models
{
    public class Lecturer : Person
    {
        public string EmployeeNumber { get; set; }
        public string Department { get; set; }
        public List<string> Courses { get; set; }

        public Lecturer(string id, string username, string firstName, string lastName, int age, string phoneNumber, string email, string picture, List<string> messages,string employeeNumber, string department, List<string> courses, string password)
            : base(id, username, firstName, lastName, age, phoneNumber, email, picture, messages, password, "Lecturer")
        {
            Department = department;
            Courses = courses;
            EmployeeNumber = employeeNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Lecturer: {FirstName} {LastName}, Department: {Department}");
        }
    }
}
