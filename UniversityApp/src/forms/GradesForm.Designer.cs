namespace UniversityApp
{
    partial class GradesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewGrades;
        private System.Windows.Forms.ColumnHeader columnCourseID;
        private System.Windows.Forms.ColumnHeader columnGrade;

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
            listViewGrades = new ListView();
            columnCourseID = new ColumnHeader();
            columnGrade = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewGrades
            // 
            listViewGrades.Columns.AddRange(new ColumnHeader[] { columnCourseID, columnGrade });
            listViewGrades.Location = new Point(12, 12);
            listViewGrades.Name = "listViewGrades";
            listViewGrades.Size = new Size(436, 369);
            listViewGrades.TabIndex = 0;
            listViewGrades.UseCompatibleStateImageBehavior = false;
            listViewGrades.View = View.Details;
            // 
            // columnCourseID
            // 
            columnCourseID.Text = "Course ID";
            columnCourseID.Width = 180;
            // 
            // columnGrade
            // 
            columnGrade.Text = "Grade";
            columnGrade.Width = 180;
            // 
            // GradesForm
            // 
            ClientSize = new Size(455, 384);
            Controls.Add(listViewGrades);
            Name = "GradesForm";
            Text = "Grades";
            ResumeLayout(false);
        }
    }
}
