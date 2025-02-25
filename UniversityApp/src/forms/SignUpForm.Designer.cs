namespace UniversityApp
{
    partial class SignUpForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.textBoxCourses = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonUploadPicture = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.checkBoxStudent = new System.Windows.Forms.CheckBox();
            this.checkBoxLecturer = new System.Windows.Forms.CheckBox();
            this.checkBoxAssistant = new System.Windows.Forms.CheckBox();
            this.checkBoxDepartment = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(20, 20);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(200, 20);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.PlaceholderText = "ID";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(20, 60);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 20);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.PlaceholderText = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(20, 100);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.PlaceholderText = "Password";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(20, 140);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFirstName.TabIndex = 4;
            this.textBoxFirstName.PlaceholderText = "First Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(20, 180);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLastName.TabIndex = 5;
            this.textBoxLastName.PlaceholderText = "Last Name";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(20, 220);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 6;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(20, 260);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.textBoxPhoneNumber.TabIndex = 7;
            this.textBoxPhoneNumber.PlaceholderText = "Phone Number";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(20, 300);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmail.TabIndex = 8;
            this.textBoxEmail.PlaceholderText = "Email";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Location = new System.Drawing.Point(20, 340);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(200, 20);
            this.comboBoxDepartment.TabIndex = 9;
            // 
            // textBoxCourses
            // 
            this.textBoxCourses.Location = new System.Drawing.Point(20, 380);
            this.textBoxCourses.Name = "textBoxCourses";
            this.textBoxCourses.Size = new System.Drawing.Size(200, 20);
            this.textBoxCourses.TabIndex = 10;
            this.textBoxCourses.PlaceholderText = "Courses (comma separated)";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(20, 420);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSignUp.TabIndex = 11;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonUploadPicture
            // 
            this.buttonUploadPicture.Location = new System.Drawing.Point(20, 460);
            this.buttonUploadPicture.Name = "buttonUploadPicture";
            this.buttonUploadPicture.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadPicture.TabIndex = 12;
            this.buttonUploadPicture.Text = "Upload";
            this.buttonUploadPicture.UseVisualStyleBackColor = true;
            this.buttonUploadPicture.Click += new System.EventHandler(this.buttonUploadPicture_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(230, 20);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 13;
            this.pictureBoxProfile.TabStop = false;
            // 
            // checkBoxStudent
            // 
            this.checkBoxStudent.Location = new System.Drawing.Point(230, 140);
            this.checkBoxStudent.Name = "checkBoxStudent";
            this.checkBoxStudent.Size = new System.Drawing.Size(100, 20);
            this.checkBoxStudent.TabIndex = 14;
            this.checkBoxStudent.Text = "Student";
            // 
            // checkBoxLecturer
            // 
            this.checkBoxLecturer.Location = new System.Drawing.Point(230, 180);
            this.checkBoxLecturer.Name = "checkBoxLecturer";
            this.checkBoxLecturer.Size = new System.Drawing.Size(100, 20);
            this.checkBoxLecturer.TabIndex = 15;
            this.checkBoxLecturer.Text = "Lecturer";
            // 
            // checkBoxAssistant
            // 
            this.checkBoxAssistant.Location = new System.Drawing.Point(230, 220);
            this.checkBoxAssistant.Name = "checkBoxAssistant";
            this.checkBoxAssistant.Size = new System.Drawing.Size(100, 20);
            this.checkBoxAssistant.TabIndex = 16;
            this.checkBoxAssistant.Text = "Assistant";
            // 
            // checkBoxDepartment
            // 
            this.checkBoxDepartment.Location = new System.Drawing.Point(230, 260);
            this.checkBoxDepartment.Name = "checkBoxDepartment";
            this.checkBoxDepartment.Size = new System.Drawing.Size(100, 20);
            this.checkBoxDepartment.TabIndex = 17;
            this.checkBoxDepartment.Text = "DepartmentHead";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            this.openFileDialog1.Title = "Select Profile Picture";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.textBoxCourses);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonUploadPicture);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.checkBoxStudent);
            this.Controls.Add(this.checkBoxLecturer);
            this.Controls.Add(this.checkBoxAssistant);
            this.Controls.Add(this.checkBoxDepartment);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.TextBox textBoxCourses;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonUploadPicture;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.CheckBox checkBoxStudent;
        private System.Windows.Forms.CheckBox checkBoxLecturer;
        private System.Windows.Forms.CheckBox checkBoxAssistant;
        private System.Windows.Forms.CheckBox checkBoxDepartment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        #endregion
    }
}
