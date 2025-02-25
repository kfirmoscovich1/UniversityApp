using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace UniversityApp
{
    public class UserLogin
    {
        private List<User> users;
        private List<Course> courses;
        private List<Department> departments;

        public UserLogin()
        {
            string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "user.json");
            string courseFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "courses.json");
            string departmentFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "departments.json");

            LoadDepartments(departmentFilePath);
            LoadUsers(userFilePath);
            LoadCourses(courseFilePath);
        }

        private void LoadDepartments(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                departments = JsonConvert.DeserializeObject<List<Department>>(json) ?? new List<Department>();
                Console.WriteLine($"Loaded {departments.Count} departments.");
            }
            else
            {
                Console.WriteLine($"Department file not found at: {filePath}");
                departments = new List<Department>();
            }
        }

        private void LoadUsers(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
                Console.WriteLine($"Loaded {users.Count} users.");
            }
            else
            {
                Console.WriteLine($"User file not found at: {filePath}");
                users = new List<User>();
            }
        }

        private void LoadCourses(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                courses = JsonConvert.DeserializeObject<List<Course>>(json);
                Console.WriteLine($"Loaded {courses.Count} courses.");
            }
            else
            {
                Console.WriteLine($"Course file not found at: {filePath}");
                courses = new List<Course>();
            }
        }

        public bool Login(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public User GetUser(string username)
        {
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }
            return null;
        }

        public List<Person> GetAllPeople()
        {
            List<Person> allPeople = new List<Person>();
            allPeople.AddRange(users);
            return allPeople;
        }

        public List<Course> GetCourses()
        {
            return courses;
        }

        public void AddUser(User user)
        {
            users.Add(user);
            SaveUsers();
        }

        private void SaveUsers()
        {
            string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "user.json");
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(userFilePath, json);
        }
    }
}
