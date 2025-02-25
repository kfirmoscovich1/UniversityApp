using System.Collections.Generic;

namespace UniversityApp.Models
{
    public class Assistant : Person
    {
        public string Department { get; set; }
        public List<string> Courses { get; set; }

        public Assistant(string id, string username, string firstName, string lastName, int age, string phoneNumber, string email, string picture, List<string> messages, string department, List<string> courses, string password)
            : base(id, username, firstName, lastName, age, phoneNumber, email, picture, messages, password, "Assistant")
        {
            Department = department;
            Courses = courses;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Assistant: {FirstName} {LastName}, Department: {Department}");
        }
    }
}
