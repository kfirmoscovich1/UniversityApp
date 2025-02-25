using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class CourseManagementForm : Form
    {
        private string courseFilePath;
        private string userFilePath;
        private List<Course> courses;
        private List<User> users;
        private List<Department> departments;
        private List<Major> majors;

        public CourseManagementForm(User user, UserLogin userLogin)
        {
            InitializeComponent();
            courseFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "courses.json");
            userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "user.json");
            EnsureFileExists(courseFilePath);
            EnsureFileExists(userFilePath);
            LoadDepartments();
            LoadMajors();
            LoadCourses();
            LoadUsers();
            PopulateDepartmentComboBox();
            PopulateExistingCoursesComboBox();
            DisplayCourses();
            DisplayStudents();
        }

        private void LoadDepartments()
        {
            string departmentsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "departments.json");
            if (File.Exists(departmentsFilePath))
            {
                string json = File.ReadAllText(departmentsFilePath);
                departments = JsonConvert.DeserializeObject<List<Department>>(json) ?? new List<Department>();
            }
            else
            {
                departments = new List<Department>();
            }
        }

        private void LoadMajors()
        {
            string majorsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "majors.json");
            if (File.Exists(majorsFilePath))
            {
                string json = File.ReadAllText(majorsFilePath);
                majors = JsonConvert.DeserializeObject<List<Major>>(json) ?? new List<Major>();
            }
            else
            {
                majors = new List<Major>();
            }
        }

        private void PopulateDepartmentComboBox()
        {
            comboBoxDepartment.Items.Clear();
            foreach (var department in departments)
            {
                comboBoxDepartment.Items.Add(department.Name);
            }
            if (comboBoxDepartment.Items.Count > 0)
            {
                comboBoxDepartment.SelectedIndex = 0;
            }
        }

        private void PopulateExistingCoursesComboBox()
        {
            comboBoxExistingCourses.Items.Clear();
            foreach (var course in courses)
            {
                comboBoxExistingCourses.Items.Add($"{course.CourseName} (ID: {course.CourseID})");
            }
        }

        private void LoadCourses()
        {
            string json = File.ReadAllText(courseFilePath);
            courses = JsonConvert.DeserializeObject<List<Course>>(json) ?? new List<Course>();
        }

        private void LoadUsers()
        {
            string json = File.ReadAllText(userFilePath);
            users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();

            foreach (var user in users)
            {
                if (user.Courses == null)
                {
                    user.Courses = new List<string>();
                }
            }
        }

        private void SaveCourses()
        {
            string json = JsonConvert.SerializeObject(courses, Formatting.Indented);
            File.WriteAllText(courseFilePath, json);
        }

        private void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(userFilePath, json);
        }

        private void DisplayCourses()
        {
            listBoxCourses.Items.Clear();
            foreach (var course in courses)
            {
                listBoxCourses.Items.Add($"{course.CourseName} (ID: {course.CourseID})");
            }
        }

        private void DisplayStudents()
        {
            listBoxStudents.Items.Clear();
            foreach (var user in users)
            {
                if (user.Type == "Student")
                {
                    listBoxStudents.Items.Add($"{user.FirstName} {user.LastName} (ID: {user.ID})");
                }
            }
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            string courseId = textBoxCourseID.Text.Trim();
            string courseName = textBoxCourseName.Text.Trim();
            string instructorId = textBoxInstructorID.Text.Trim();
            string instructorName = textBoxInstructorName.Text.Trim();
            var selectedStudents = listBoxStudents.SelectedItems.Cast<string>().Select(s => s.Split(new[] { '(', ')' })[1].Replace("ID: ", "").Trim()).ToList();
            string selectedDepartmentName = comboBoxDepartment.SelectedItem?.ToString();
            var schedule = new List<Schedule>
            {
                new Schedule(comboBoxDay.SelectedItem.ToString(), textBoxTime.Text.Trim())
            };

            if (!string.IsNullOrEmpty(courseId) && !string.IsNullOrEmpty(courseName) && !string.IsNullOrEmpty(instructorId) && !string.IsNullOrEmpty(instructorName))
            {
                if (string.IsNullOrEmpty(selectedDepartmentName))
                {
                    MessageBox.Show("Please select a valid department.");
                    return;
                }

                var newCourse = new Course(courseId, courseName, instructorId, instructorName, selectedDepartmentName, selectedStudents, schedule);
                courses.Add(newCourse);
                SaveCourses();

                foreach (var studentId in selectedStudents)
                {
                    var student = users.FirstOrDefault(u => u.ID == studentId);
                    if (student != null && !student.Courses.Contains(courseId))
                    {
                        student.Courses.Add(courseId);
                    }
                }
                SaveUsers();

                DisplayCourses();
                PopulateExistingCoursesComboBox();
                MessageBox.Show("Course added successfully.");
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }
        }

        private void buttonUpdateCourse_Click(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem != null)
            {
                string selectedCourse = listBoxCourses.SelectedItem.ToString();
                string courseId = selectedCourse.Split('(')[1].Replace("ID: ", "").Replace(")", "").Trim();
                var selectedStudents = listBoxStudents.SelectedItems.Cast<string>().Select(s => s.Split(new[] { '(', ')' })[1].Replace("ID: ", "").Trim()).ToList();
                string selectedDepartmentName = comboBoxDepartment.SelectedItem?.ToString();
                var schedule = new List<Schedule>
                {
                    new Schedule(comboBoxDay.SelectedItem.ToString(), textBoxTime.Text.Trim())
                };

                var course = courses.FirstOrDefault(c => c.CourseID == courseId);
                if (course != null)
                {
                    course.CourseName = textBoxCourseName.Text.Trim();
                    course.InstructorID = textBoxInstructorID.Text.Trim();
                    course.InstructorName = textBoxInstructorName.Text.Trim();
                    course.Students = selectedStudents;
                    course.DepartmentName = selectedDepartmentName;
                    course.Schedule = schedule;
                    SaveCourses();

                    foreach (var student in users)
                    {
                        if (student.Type == "Student")
                        {
                            if (selectedStudents.Contains(student.ID) && !student.Courses.Contains(courseId))
                            {
                                student.Courses.Add(courseId);
                            }
                            else if (!selectedStudents.Contains(student.ID) && student.Courses.Contains(courseId))
                            {
                                student.Courses.Remove(courseId);
                            }
                        }
                    }
                    SaveUsers();

                    DisplayCourses();
                    MessageBox.Show("Course updated successfully.");
                }
            }
        }

        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem != null)
            {
                string selectedCourse = listBoxCourses.SelectedItem.ToString();
                string courseId = selectedCourse.Split('(')[1].Replace("ID: ", "").Replace(")", "").Trim();

                var course = courses.FirstOrDefault(c => c.CourseID == courseId);
                if (course != null)
                {
                    courses.Remove(course);
                    SaveCourses();

                    foreach (var student in users)
                    {
                        if (student.Type == "Student" && student.Courses.Contains(courseId))
                        {
                            student.Courses.Remove(courseId);
                        }
                    }
                    SaveUsers();

                    DisplayCourses();
                    MessageBox.Show("Course deleted successfully.");
                }
            }
        }

        private void buttonAddSchedule_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAddExistingCourse_Click(object sender, EventArgs e)
        {
            if (comboBoxExistingCourses.SelectedItem != null && listBoxStudents.SelectedItems.Count > 0)
            {
                string selectedCourse = comboBoxExistingCourses.SelectedItem.ToString();
                string courseId = selectedCourse.Split('(')[1].Replace("ID: ", "").Replace(")", "").Trim();
                var selectedStudents = listBoxStudents.SelectedItems.Cast<string>().Select(s => s.Split(new[] { '(', ')' })[1].Replace("ID: ", "").Trim()).ToList();

                var course = courses.FirstOrDefault(c => c.CourseID == courseId);
                if (course != null)
                {
                    foreach (var studentId in selectedStudents)
                    {
                        if (!course.Students.Contains(studentId))
                        {
                            course.Students.Add(studentId);
                        }

                        var student = users.FirstOrDefault(u => u.ID == studentId);
                        if (student != null && !student.Courses.Contains(courseId))
                        {
                            student.Courses.Add(courseId);
                        }
                    }
                    SaveCourses();
                    SaveUsers();
                    MessageBox.Show("Students added to existing course successfully.");
                }
            }
        }

        private void EnsureFileExists(string path)
        {
            string directoryPath = Path.GetDirectoryName(path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[]"); 
            }
        }
    }
}
