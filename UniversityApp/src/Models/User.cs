using System;
using System.Collections.Generic;

namespace UniversityApp
{
    public class User : Person
    {
        public string IDNumber { get; set; }
        public string Major { get; set; }
        public int CreditPoints { get; set; }
        public string Department { get; set; }
        public List<string> Courses { get; set; }

        public User(string id, string username, string firstName, string lastName, int age, string phoneNumber, string email, string picture, List<string> messages, string type, string major, int creditPoints, string department, List<string> courses, string password)
            : base(id, username, firstName, lastName, age, phoneNumber, email, picture, messages, password, type)
        {
            Major = major;
            CreditPoints = creditPoints;
            Department = department;
            Courses = courses ?? new List<string>();
            IDNumber = GenerateIDNumber(type);
        }

        private string GenerateIDNumber(string userType)
        {
            if (userType == "Student")
            {
                return $"S{new Random().Next(10000, 99999)}"; 
            }
            else if (userType == "Lecturer" || userType == "Assistant" || userType == "DepartmentHead")
            {
                return $"E{new Random().Next(1000, 9999)}"; 
            }
            return "";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"User: {FirstName} {LastName}, ID: {ID}, Type: {Type}, Department: {Department}, Major: {Major}");
        }
    }
}
