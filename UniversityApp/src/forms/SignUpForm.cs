// עדכון טופס ההרשמה להוספת אימות נתונים
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class SignUpForm : Form
    {
        private UserLogin userLogin;
        private List<User> users;
        private List<Department> departments;

        public SignUpForm(UserLogin login, List<Department> departments)
        {
            InitializeComponent();
            userLogin = login;
            this.departments = departments;
            users = LoadUsers();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            // בדיקה אם המשתמש קיים
            if (users.Any(u => u.ID == id || u.Username == username))
            {
                MessageBox.Show("User with this ID or username already exists.");
                return;
            }

            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            int age = DateTime.Now.Year - dateTimePickerDOB.Value.Year;
            string phoneNumber = textBoxPhoneNumber.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string departmentName = comboBoxDepartment.SelectedItem?.ToString();
            string userType = GetUserType();
            string idNumber = userType == "Student" ? GenerateStudentNumber() : GenerateEmployeeNumber();

            var newUser = new User(id, username, firstName, lastName, age, phoneNumber, email, "", new List<string>(), userType, null, 0, departmentName, new List<string>(), password)
            {
                IDNumber = idNumber
            };

            users.Add(newUser);
            SaveUsers(users);
            MessageBox.Show("User registered successfully.");
            this.Close();
        }

        private List<User> LoadUsers()
        {
            string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "user.json");
            if (!File.Exists(userFilePath))
            {
                File.WriteAllText(userFilePath, "[]");
            }
            return JsonSerializer.Deserialize<List<User>>(File.ReadAllText(userFilePath)) ?? new List<User>();
        }

        private void SaveUsers(List<User> users)
        {
            string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "user.json");
            File.WriteAllText(userFilePath, JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
