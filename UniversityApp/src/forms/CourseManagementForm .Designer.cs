namespace UniversityApp
{
    partial class CourseManagementForm
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
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxInstructorID = new System.Windows.Forms.TextBox();
            this.textBoxInstructorName = new System.Windows.Forms.TextBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonUpdateCourse = new System.Windows.Forms.Button();
            this.buttonDeleteCourse = new System.Windows.Forms.Button();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxExistingCourses = new System.Windows.Forms.ComboBox();
            this.buttonAddExistingCourse = new System.Windows.Forms.Button();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonAddSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(12, 12);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(200, 27);
            this.textBoxCourseID.TabIndex = 0;
            this.textBoxCourseID.Text = "Course ID";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(12, 45);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(200, 27);
            this.textBoxCourseName.TabIndex = 1;
            this.textBoxCourseName.Text = "Course Name";
            // 
            // textBoxInstructorID
            // 
            this.textBoxInstructorID.Location = new System.Drawing.Point(12, 78);
            this.textBoxInstructorID.Name = "textBoxInstructorID";
            this.textBoxInstructorID.Size = new System.Drawing.Size(200, 27);
            this.textBoxInstructorID.TabIndex = 2;
            this.textBoxInstructorID.Text = "Instructor ID";
            // 
            // textBoxInstructorName
            // 
            this.textBoxInstructorName.Location = new System.Drawing.Point(12, 111);
            this.textBoxInstructorName.Name = "textBoxInstructorName";
            this.textBoxInstructorName.Size = new System.Drawing.Size(200, 27);
            this.textBoxInstructorName.TabIndex = 3;
            this.textBoxInstructorName.Text = "Instructor Name";
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 20;
            this.listBoxStudents.Location = new System.Drawing.Point(12, 177);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxStudents.Size = new System.Drawing.Size(330, 164);
            this.listBoxStudents.TabIndex = 4;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(12, 347);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(200, 29);
            this.buttonAddCourse.TabIndex = 5;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // buttonUpdateCourse
            // 
            this.buttonUpdateCourse.Location = new System.Drawing.Point(12, 382);
            this.buttonUpdateCourse.Name = "buttonUpdateCourse";
            this.buttonUpdateCourse.Size = new System.Drawing.Size(200, 29);
            this.buttonUpdateCourse.TabIndex = 6;
            this.buttonUpdateCourse.Text = "Update Course";
            this.buttonUpdateCourse.UseVisualStyleBackColor = true;
            this.buttonUpdateCourse.Click += new System.EventHandler(this.buttonUpdateCourse_Click);
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.Location = new System.Drawing.Point(12, 417);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(200, 29);
            this.buttonDeleteCourse.TabIndex = 7;
            this.buttonDeleteCourse.Text = "Delete Course";
            this.buttonDeleteCourse.UseVisualStyleBackColor = true;
            this.buttonDeleteCourse.Click += new System.EventHandler(this.buttonDeleteCourse_Click);
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 20;
            this.listBoxCourses.Location = new System.Drawing.Point(218, 12);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(330, 144);
            this.listBoxCourses.TabIndex = 8;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(12, 144);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(200, 28);
            this.comboBoxDepartment.TabIndex = 9;
            // 
            // comboBoxExistingCourses
            // 
            this.comboBoxExistingCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExistingCourses.FormattingEnabled = true;
            this.comboBoxExistingCourses.Location = new System.Drawing.Point(218, 182);
            this.comboBoxExistingCourses.Name = "comboBoxExistingCourses";
            this.comboBoxExistingCourses.Size = new System.Drawing.Size(330, 28);
            this.comboBoxExistingCourses.TabIndex = 10;
            // 
            // buttonAddExistingCourse
            // 
            this.buttonAddExistingCourse.Location = new System.Drawing.Point(218, 216);
            this.buttonAddExistingCourse.Name = "buttonAddExistingCourse";
            this.buttonAddExistingCourse.Size = new System.Drawing.Size(330, 29);
            this.buttonAddExistingCourse.TabIndex = 11;
            this.buttonAddExistingCourse.Text = "Add Existing Course";
            this.buttonAddExistingCourse.UseVisualStyleBackColor = true;
            this.buttonAddExistingCourse.Click += new System.EventHandler(this.buttonAddExistingCourse_Click);
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.comboBoxDay.Location = new System.Drawing.Point(218, 261);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(200, 28);
            this.comboBoxDay.TabIndex = 12;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(218, 295);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(200, 27);
            this.textBoxTime.TabIndex = 13;
            this.textBoxTime.Text = "Time (HH:MM-HH:MM)";
            // 
            // buttonAddSchedule
            // 
            this.buttonAddSchedule.Location = new System.Drawing.Point(218, 328);
            this.buttonAddSchedule.Name = "buttonAddSchedule";
            this.buttonAddSchedule.Size = new System.Drawing.Size(200, 29);
            this.buttonAddSchedule.TabIndex = 14;
            this.buttonAddSchedule.Text = "Add Schedule";
            this.buttonAddSchedule.UseVisualStyleBackColor = true;
            this.buttonAddSchedule.Click += new System.EventHandler(this.buttonAddSchedule_Click);
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 460);
            this.Controls.Add(this.buttonAddSchedule);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.buttonAddExistingCourse);
            this.Controls.Add(this.comboBoxExistingCourses);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.buttonDeleteCourse);
            this.Controls.Add(this.buttonUpdateCourse);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.textBoxInstructorName);
            this.Controls.Add(this.textBoxInstructorID);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.textBoxCourseID);
            this.Name = "CourseManagementForm";
            this.Text = "Course Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxInstructorID;
        private System.Windows.Forms.TextBox textBoxInstructorName;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonUpdateCourse;
        private System.Windows.Forms.Button buttonDeleteCourse;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxExistingCourses;
        private System.Windows.Forms.Button buttonAddExistingCourse;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonAddSchedule;
    }
}
