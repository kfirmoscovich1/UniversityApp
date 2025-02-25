// UserManagementForm.Designer.cs - עיצוב טופס ניהול משתמשים
using System.Windows.Forms;

namespace UniversityApp
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewUsers;
        private Button buttonEditUser;
        private Button buttonDeleteUser;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelEmail;
        private Label labelPhoneNumber;

        private void InitializeComponent()
        {
            this.listViewUsers = new ListView();
            this.buttonEditUser = new Button();
            this.buttonDeleteUser = new Button();
            this.textBoxFirstName = new TextBox();
            this.textBoxLastName = new TextBox();
            this.textBoxEmail = new TextBox();
            this.textBoxPhoneNumber = new TextBox();
            this.labelFirstName = new Label();
            this.labelLastName = new Label();
            this.labelEmail = new Label();
            this.labelPhoneNumber = new Label();

            this.SuspendLayout();

            // listViewUsers
            this.listViewUsers.Location = new System.Drawing.Point(12, 12);
            this.listViewUsers.Size = new System.Drawing.Size(460, 200);

            // buttonEditUser
            this.buttonEditUser.Text = "Edit User";
            this.buttonEditUser.Location = new System.Drawing.Point(12, 300);
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);

            // buttonDeleteUser
            this.buttonDeleteUser.Text = "Delete User";
            this.buttonDeleteUser.Location = new System.Drawing.Point(100, 300);
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);

            // TextBoxes
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 230);
            this.textBoxLastName.Location = new System.Drawing.Point(120, 230);
            this.textBoxEmail.Location = new System.Drawing.Point(230, 230);
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(340, 230);

            // Labels
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.Location = new System.Drawing.Point(12, 210);

            this.labelLastName.Text = "Last Name";
            this.labelLastName.Location = new System.Drawing.Point(120, 210);

            this.labelEmail.Text = "Email";
            this.labelEmail.Location = new System.Drawing.Point(230, 210);

            this.labelPhoneNumber.Text = "Phone";
            this.labelPhoneNumber.Location = new System.Drawing.Point(340, 210);

            // UserManagementForm
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNumber);
            this.ResumeLayout(false);
        }
    }
}