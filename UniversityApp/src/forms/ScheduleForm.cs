using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class ScheduleForm : Form
    {
        private User loggedInUser;
        private string displayMode = "Light";
        private string textSize = "Medium";

        public ScheduleForm(User user, List<Course> courses)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadSettings();
            DisplaySchedule(courses);
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

        private void DisplaySchedule(List<Course> courses)
        {
            var scheduleTable = new DataTable();
            scheduleTable.Columns.Add("Course");
            scheduleTable.Columns.Add("Instructor");
            scheduleTable.Columns.Add("Schedule");

            foreach (var course in courses)
            {
                var schedules = course.Schedule.Select(s => $"{s.Day}: {s.Time}");
                scheduleTable.Rows.Add(course.CourseName, course.InstructorName, string.Join(", ", schedules));
            }

            dataGridView1.DataSource = scheduleTable;
        }
    }
}
