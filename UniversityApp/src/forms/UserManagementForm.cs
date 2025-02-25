// עדכון מערכת עריכת נתוני משתמשים
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class UserManagementForm : Form
    {
        private List<User> users;
        private string userFilePath;
        private string displayMode = "Light";
        private string textSize = "Medium";

        public UserManagementForm()
        {
            InitializeComponent();
            userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "user.json");
            LoadUsers();
            LoadSettings();
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

        private void LoadUsers()
        {
            if (!File.Exists(userFilePath))
            {
                File.WriteAllText(userFilePath, "[]");
            }
            users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(userFilePath)) ?? new List<User>();
            DisplayUsers();
        }

        private void DisplayUsers()
        {
            listViewUsers.Items.Clear();
            foreach (var user in users)
            {
                var listViewItem = new ListViewItem(new[] {
                    user.ID,
                    user.Username,
                    user.FirstName + " " + user.LastName,
                    user.Email,
                    user.PhoneNumber
                });
                listViewUsers.Items.Add(listViewItem);
            }
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            string userId = listViewUsers.SelectedItems[0].SubItems[0].Text;
            var user = users.FirstOrDefault(u => u.ID == userId);
            if (user == null) return;

            user.FirstName = textBoxFirstName.Text.Trim();
            user.LastName = textBoxLastName.Text.Trim();
            user.Email = textBoxEmail.Text.Trim();
            user.PhoneNumber = textBoxPhoneNumber.Text.Trim();
            SaveUsers();
            DisplayUsers();
            MessageBox.Show("User details updated successfully.");
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            string userId = listViewUsers.SelectedItems[0].SubItems[0].Text;
            users.RemoveAll(u => u.ID == userId);
            SaveUsers();
            DisplayUsers();
            MessageBox.Show("User deleted successfully.");
        }

        private void SaveUsers()
        {
            File.WriteAllText(userFilePath, JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
