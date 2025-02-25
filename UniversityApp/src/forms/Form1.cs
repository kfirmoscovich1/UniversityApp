using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using UniversityApp.Models;

namespace UniversityApp
{
    public partial class Form1 : Form
    {
        private UserLogin userLogin;
        private User loggedInUser;
        private string displayMode = "Light";
        private string textSize = "Medium";

        public Form1()
        {
            InitializeComponent();
            userLogin = new UserLogin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void ApplySettings()
        {
            this.BackColor = displayMode == "Dark" ? Color.Black : Color.White;
            this.ForeColor = displayMode == "Dark" ? Color.White : Color.Black;

            foreach (Control control in this.Controls)
            {
                control.BackColor = this.BackColor;
                control.ForeColor = this.ForeColor;

                switch (textSize)
                {
                    case "Small":
                        control.Font = new Font(control.Font.FontFamily, 8);
                        break;
                    case "Medium":
                        control.Font = new Font(control.Font.FontFamily, 12);
                        break;
                    case "Large":
                        control.Font = new Font(control.Font.FontFamily, 16);
                        break;
                }
            }
            AdjustTextBoxSize(textSize);
        }

        private void AdjustTextBoxSize(string size)
        {
            int width = size == "Small" ? 150 : size == "Medium" ? 200 : 250;
            int height = size == "Small" ? 20 : size == "Medium" ? 30 : 40;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Width = width;
                    textBox.Height = height;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                UncheckOtherCheckBoxes(checkBox1);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                UncheckOtherCheckBoxes(checkBox2);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                UncheckOtherCheckBoxes(checkBox3);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                UncheckOtherCheckBoxes(checkBox4);
            }
        }

        private void UncheckOtherCheckBoxes(CheckBox currentCheckBox)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is CheckBox checkBox && checkBox != currentCheckBox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            bool isValidUser = userLogin.Login(username, password);

            if (isValidUser)
            {
                loggedInUser = userLogin.GetUser(username);
                if (loggedInUser != null && IsUserTypeCorrect(loggedInUser))
                {
                    MessageBox.Show($"Welcome: {loggedInUser.FirstName} {loggedInUser.LastName}, Type: {loggedInUser.Type}");
                    Form2 newForm = new Form2(loggedInUser, userLogin);
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User type does not match.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool IsUserTypeCorrect(User user)
        {
            return (checkBox1.Checked && user.Type == "Student") ||
                   (checkBox2.Checked && user.Type == "Lecturer") ||
                   (checkBox3.Checked && user.Type == "Assistant") ||
                   (checkBox4.Checked && user.Type == "DepartmentHead");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Department> departments = GetDepartments();
            SignUpForm signUpForm = new SignUpForm(userLogin, departments);
            signUpForm.Show();
        }

        private List<Department> GetDepartments()
        {
            string departmentsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "departments.json");
            if (File.Exists(departmentsFilePath))
            {
                string json = File.ReadAllText(departmentsFilePath);
                return JsonSerializer.Deserialize<List<Department>>(json) ?? new List<Department>();
            }
            return new List<Department>();
        }

        private void buttonOpenSearch_Click(object sender, EventArgs e)
        {
            List<Person> allPeople = userLogin.GetAllPeople();
            Debug.WriteLine($"Opening search with {allPeople.Count} people");
            SearchForm searchForm = new SearchForm(allPeople, loggedInUser);
            searchForm.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.SettingsChanged += (mode, size) =>
            {
                displayMode = mode;
                textSize = size;
                ApplySettings();
            };
            settingsForm.Show();
        }
    }
}
