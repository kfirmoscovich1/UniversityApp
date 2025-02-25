using System.Collections.Generic;

namespace UniversityApp
{
    public class Manager : Person
    {
        public string Type { get; } = "Manager";

        public Manager(string id, string username, string firstName, string lastName, int age, string phoneNumber, string email, string picture, List<string> messages, string password)
            : base(id, username, firstName, lastName, age, phoneNumber, email, picture, messages, password, "Manager")
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {FirstName} {LastName}, ID: {ID}, Age: {Age}, Phone: {PhoneNumber}, Email: {Email}");
        }
    }
}
