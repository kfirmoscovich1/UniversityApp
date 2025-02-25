// עדכון חיפוש משתמשים לתמיכה במספר סטודנט/עובד
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class SearchForm : Form
    {
        private List<Person> people;
        private User loggedInUser;

        public SearchForm(List<Person> people, User user)
        {
            InitializeComponent();
            this.people = people;
            this.loggedInUser = user;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = textBoxSearch.Text.Trim().ToLower();

            var results = people
                .Where(p => p.FirstName.ToLower().Contains(query) ||
                            p.LastName.ToLower().Contains(query) ||
                            p.ID.Contains(query) ||
                            (p is Student student && student.StudentNumber.Contains(query)) ||
                            (p is Lecturer lecturer && lecturer.EmployeeNumber.Contains(query)))
                .ToList();

            listBoxResults.Items.Clear();
            if (results.Any())
            {
                foreach (var person in results)
                {
                    listBoxResults.Items.Add($"{person.FirstName} {person.LastName} (ID: {person.ID})");
                }
            }
            else
            {
                listBoxResults.Items.Add("No results found.");
            }
        }
    }
}
