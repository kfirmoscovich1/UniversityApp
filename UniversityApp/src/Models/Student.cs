using System.Collections.Generic;

namespace UniversityApp
{
    public class Student : Person
    {
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        public int CreditPoints { get; set; }

        public Student(string id, string username, string firstName, string lastName, int age, string phoneNumber, string email, string picture, List<string> messages, string studentNumber, string major, int creditPoints, string password)
            : base(id, username, firstName, lastName, age, phoneNumber, email, picture, messages, password, "Student")
        {
            StudentNumber = studentNumber;
            Major = major;
            CreditPoints = creditPoints;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Student: {FirstName} {LastName}, Major: {Major}");
        }
    }
}
