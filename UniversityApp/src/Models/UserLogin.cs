
// UserLogin.cs - מחלקת התחברות משתמשים (תיקון הצגת שם)
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace UniversityApp
{
    public class UserLogin
    {
        private List<User> users;
        private string userFilePath;

        public UserLogin()
        {
            userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "user.json");
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (!File.Exists(userFilePath))
            {
                File.WriteAllText(userFilePath, "[]");
            }
            users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(userFilePath)) ?? new List<User>();
        }

        public User AuthenticateUser(string username, string password)
        {
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Console.WriteLine($"Welcome {user.FirstName} {user.LastName}"); // הצגת שם ושם משפחה במקום סיסמה
            }
            return user;
        }
    }
}
