using System.Collections.Generic;

namespace UniversityApp
{
    public class Person
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
        public string Password { get; set; }
        public string Type { get; set; }

        public Person(string id, string username, string firstName, string lastName, int age, string phoneNumber, string email, string picture, List<string> messages, string password, string type)
        {
            ID = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
            Picture = picture;
            Messages = messages;
            Password = password;
            Type = type;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}, ID: {ID}");
        }
    }
}
