namespace UniversityApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            welcomeLabel = new Label();
            profilePictureBox = new PictureBox();
            scheduleButton = new Button();
            gradesButton = new Button();
            profileButton = new Button();
            messagesButton = new Button();
            searchButton = new Button();
            manageCoursesButton = new Button();
            logoutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(10, 7);
            welcomeLabel.Margin = new Padding(2, 0, 2, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(71, 20);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome";
            // 
            // profilePictureBox
            // 
            profilePictureBox.Location = new Point(446, 7);
            profilePictureBox.Margin = new Padding(2);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(183, 166);
            profilePictureBox.TabIndex = 1;
            profilePictureBox.TabStop = false;
            // 
            // scheduleButton
            // 
            scheduleButton.Location = new Point(10, 83);
            scheduleButton.Margin = new Padding(2);
            scheduleButton.Name = "scheduleButton";
            scheduleButton.Size = new Size(109, 39);
            scheduleButton.TabIndex = 2;
            scheduleButton.Text = "Schedule";
            scheduleButton.UseVisualStyleBackColor = true;
            scheduleButton.Click += scheduleButton_Click;
            // 
            // gradesButton
            // 
            gradesButton.Location = new Point(10, 126);
            gradesButton.Margin = new Padding(2);
            gradesButton.Name = "gradesButton";
            gradesButton.Size = new Size(109, 39);
            gradesButton.TabIndex = 3;
            gradesButton.Text = "Grades";
            gradesButton.UseVisualStyleBackColor = true;
            gradesButton.Click += gradesButton_Click;
            // 
            // profileButton
            // 
            profileButton.Location = new Point(10, 169);
            profileButton.Margin = new Padding(2);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(109, 36);
            profileButton.TabIndex = 4;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
            // 
            // messagesButton
            // 
            messagesButton.Location = new Point(10, 210);
            messagesButton.Margin = new Padding(2);
            messagesButton.Name = "messagesButton";
            messagesButton.Size = new Size(109, 38);
            messagesButton.TabIndex = 5;
            messagesButton.Text = "Messages";
            messagesButton.UseVisualStyleBackColor = true;
            messagesButton.Click += messagesButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(10, 252);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(109, 39);
            searchButton.TabIndex = 6;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // manageCoursesButton
            // 
            manageCoursesButton.Location = new Point(10, 295);
            manageCoursesButton.Margin = new Padding(2);
            manageCoursesButton.Name = "manageCoursesButton";
            manageCoursesButton.Size = new Size(109, 36);
            manageCoursesButton.TabIndex = 7;
            manageCoursesButton.Text = "Manage Courses";
            manageCoursesButton.UseVisualStyleBackColor = true;
            manageCoursesButton.Click += manageCoursesButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(526, 311);
            logoutButton.Margin = new Padding(2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(103, 38);
            logoutButton.TabIndex = 8;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(logoutButton);
            Controls.Add(manageCoursesButton);
            Controls.Add(searchButton);
            Controls.Add(messagesButton);
            Controls.Add(profileButton);
            Controls.Add(gradesButton);
            Controls.Add(scheduleButton);
            Controls.Add(profilePictureBox);
            Controls.Add(welcomeLabel);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button gradesButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button messagesButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button manageCoursesButton;
        private System.Windows.Forms.Button logoutButton; 
    }
}
