using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class GradesForm : Form
    {
        private User loggedInUser;
        private string displayMode = "Light";
        private string textSize = "Medium";

        public GradesForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadSettings();
            DisplayGrades();
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

        private void DisplayGrades()
        {
            var gradesData = LoadGrades();

            var userGradesData = gradesData.FirstOrDefault(g => g.UserID == loggedInUser.ID)?.Grades;

            if (userGradesData != null)
            {
                foreach (var gradeEntry in userGradesData)
                {
                    var listViewItem = new ListViewItem(new[] {
                        gradeEntry.CourseID,
                        gradeEntry.Score.ToString()
                    });
                    listViewGrades.Items.Add(listViewItem);
                }
            }
        }

        private List<Grade> LoadGrades()
        {
            string gradesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "grades.json");
            if (!File.Exists(gradesFilePath))
            {
                File.WriteAllText(gradesFilePath, "[]");
            }

            string json = File.ReadAllText(gradesFilePath);
            return JsonSerializer.Deserialize<List<Grade>>(json) ?? new List<Grade>();
        }
    }
}
