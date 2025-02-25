// עדכון מערכת ניהול מסלולים על ידי ראש מחלקה
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class DepartmentManagementForm : Form
    {
        private User loggedInUser;
        private List<Department> departments;
        private string displayMode = "Light";
        private string textSize = "Medium";

        public DepartmentManagementForm(User user, List<Department> departments)
        {
            InitializeComponent();
            loggedInUser = user;
            this.departments = departments;
            LoadSettings();
            DisplayDepartments();
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
                control.Font = new Font(control.Font.FontFamily, textSize == "Small" ? 8 : textSize == "Medium" ? 12 : 16);
            }
        }

        private void DisplayDepartments()
        {
            listViewDepartments.Items.Clear();
            foreach (var department in departments)
            {
                var listViewItem = new ListViewItem(new[] {
                    department.Name,
                    department.Courses.Count.ToString(),
                    department.Lecturers.Count.ToString(),
                    department.Students.Count.ToString()
                });

                listViewDepartments.Items.Add(listViewItem);
            }
        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            string departmentName = textBoxDepartmentName.Text.Trim();
            if (string.IsNullOrEmpty(departmentName))
            {
                MessageBox.Show("Please enter a department name.");
                return;
            }

            if (departments.Any(d => d.Name == departmentName))
            {
                MessageBox.Show("Department already exists.");
                return;
            }

            var newDepartment = new Department { Name = departmentName, Courses = new List<Course>(), Lecturers = new List<Lecturer>(), Students = new List<Student>() };
            departments.Add(newDepartment);
            SaveDepartments();
            DisplayDepartments();
            MessageBox.Show("Department added successfully.");
        }

        private void buttonRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (listViewDepartments.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a department to remove.");
                return;
            }

            string departmentName = listViewDepartments.SelectedItems[0].SubItems[0].Text;
            departments.RemoveAll(d => d.Name == departmentName);
            SaveDepartments();
            DisplayDepartments();
            MessageBox.Show("Department removed successfully.");
        }

        private void SaveDepartments()
        {
            string departmentsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "departments.json");
            File.WriteAllText(departmentsFilePath, JsonSerializer.Serialize(departments, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
