using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class Form2 : Form
    {
        private User loggedInUser;
        private UserLogin userLogin;
        private string displayMode = "Light";
        private string textSize = "Medium";

        public Form2(User user, UserLogin userLogin)
        {
            InitializeComponent();
            loggedInUser = user;
            this.userLogin = userLogin;
            LoadSettings();
            ApplySettings();
            AdjustMenuOptions();
            DisplayUserInfo();
        }

        private void LoadSettings()
        {
            string settingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "settings.json");
            if (File.Exists(settingsFilePath))
            {
                string json = File.ReadAllText(settingsFilePath);
                var settings = JsonConvert.DeserializeObject<AppSettings>(json) ?? new AppSettings();

                displayMode = settings.DarkMode ? "Dark" : "Light";
                textSize = settings.TextSize;
            }
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

        private void AdjustMenuOptions()
        {
            if (loggedInUser.Type != "Student")
            {
                gradesButton.Visible = false;
            }

            if (loggedInUser.Type == "Lecturer" || loggedInUser.Type == "DepartmentHead")
            {
                manageCoursesButton.Visible = true;
            }
            else
            {
                manageCoursesButton.Visible = false;
            }
        }

        private void DisplayUserInfo()
        {
            welcomeLabel.Text = $"Welcome, {loggedInUser.FirstName} {loggedInUser.LastName}";
            if (!string.IsNullOrEmpty(loggedInUser.Picture))
            {
                try
                {
                    profilePictureBox.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, loggedInUser.Picture));
                }
                catch
                {
                    profilePictureBox.Image = null; // אם לא ניתן לטעון את התמונה
                }
            }
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(loggedInUser, LoadCourses());
            scheduleForm.Show();
        }

        private void gradesButton_Click(object sender, EventArgs e)
        {
            GradesForm gradesForm = new GradesForm(loggedInUser);
            gradesForm.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(loggedInUser);
            profileForm.Show();
        }

        private void messagesButton_Click(object sender, EventArgs e)
        {
            MessagesForm messagesForm = new MessagesForm(loggedInUser);
            messagesForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Person> allPeople = userLogin.GetAllPeople();
            SearchForm searchForm = new SearchForm(allPeople, loggedInUser);
            searchForm.Show();
        }

        private void manageCoursesButton_Click(object sender, EventArgs e)
        {
            CourseManagementForm courseManagementForm = new CourseManagementForm(loggedInUser, userLogin);
            courseManagementForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private List<Course> LoadCourses()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "courses.json");
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Course>>(json);
        }
    }
}
