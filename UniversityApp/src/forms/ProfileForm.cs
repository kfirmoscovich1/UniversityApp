using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class ProfileForm : Form
    {
        private User loggedInUser;
        private string displayMode = "Light";
        private string textSize = "Medium";

        public ProfileForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadSettings();
            DisplayUserInfo();
        }

        private void LoadSettings()
        {
            string settingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "settings.json");
            if (File.Exists(settingsFilePath))
            {
                string json = File.ReadAllText(settingsFilePath);
                var settings = JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings();
                displayMode = settings.DarkMode ? "Dark" : "Light";
                textSize = settings.TextSize;
                ApplySettings();
            }
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

        private void ApplySettings()
        {
            this.BackColor = displayMode == "Dark" ? Color.Black : Color.White;
            this.ForeColor = displayMode == "Dark" ? Color.White : Color.Black;

            foreach (Control control in this.Controls)
            {
                control.BackColor = this.BackColor;
                control.ForeColor = this.ForeColor;

                if (textSize == "Small")
                    control.Font = new Font(control.Font.FontFamily, 8);
                else if (textSize == "Medium")
                    control.Font = new Font(control.Font.FontFamily, 12);
            }
        }

        private void DisplayUserInfo()
        {
            nameLabel.Text = $"{loggedInUser.FirstName} {loggedInUser.LastName}";
            ageLabel.Text = $"Age: {loggedInUser.Age}";
            phoneLabel.Text = $"Phone: {loggedInUser.PhoneNumber}";
            emailLabel.Text = $"Email: {loggedInUser.Email}";

            if (loggedInUser.Type == "Student")
            {
                studentNumberLabel.Text = $"Student Number: {loggedInUser.IDNumber}";
                majorLabel.Text = $"Major: {loggedInUser.Major}";
                creditPointsLabel.Text = $"Credit Points: {loggedInUser.CreditPoints}";
            }
            else
            {
                studentNumberLabel.Text = $"Employee Number: {loggedInUser.IDNumber}";
            }

            departmentLabel.Text = $"Department: {loggedInUser.Department}";

            if (!string.IsNullOrEmpty(loggedInUser.Picture) && File.Exists(loggedInUser.Picture))
            {
                profilePictureBox.ImageLocation = loggedInUser.Picture;
            }
            else
            {
                profilePictureBox.Image = null; 
            }
        }
    }
}
