// עדכון מערכת ניהול הודעות - סינון וסידור הודעות
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class MessagesForm : Form
    {
        private User loggedInUser;
        private string displayMode = "Light";
        private string textSize = "Medium";
        private List<Message> messages;

        public MessagesForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadSettings();
            messages = LoadMessages();
            DisplayMessages();
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

        private void DisplayMessages()
        {
            var filteredMessages = messages
                .Where(m => m.Receiver == loggedInUser.ID)
                .OrderByDescending(m => DateTime.Parse(m.Date))
                .ToList();

            listViewMessages.Items.Clear();
            foreach (var message in filteredMessages)
            {
                var listViewItem = new ListViewItem(new[] {
                    message.Date,
                    message.Sender,
                    message.Content,
                    message.Importance
                });

                listViewMessages.Items.Add(listViewItem);
            }
        }

        private List<Message> LoadMessages()
        {
            string messageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "message.json");
            if (!File.Exists(messageFilePath))
            {
                File.WriteAllText(messageFilePath, "[]");
            }

            string json = File.ReadAllText(messageFilePath);
            return JsonSerializer.Deserialize<List<Message>>(json) ?? new List<Message>();
        }

        private void buttonSortByDate_Click(object sender, EventArgs e)
        {
            messages = messages.OrderByDescending(m => DateTime.Parse(m.Date)).ToList();
            DisplayMessages();
        }

        private void buttonSortByImportance_Click(object sender, EventArgs e)
        {
            messages = messages.OrderByDescending(m => m.Importance == "High").ThenBy(m => DateTime.Parse(m.Date)).ToList();
            DisplayMessages();
        }

        private void buttonSortByStarred_Click(object sender, EventArgs e)
        {
            messages = messages.OrderByDescending(m => m.IsStarred).ThenBy(m => DateTime.Parse(m.Date)).ToList();
            DisplayMessages();
        }
    }
}
