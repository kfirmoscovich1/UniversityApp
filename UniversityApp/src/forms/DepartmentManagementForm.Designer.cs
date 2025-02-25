// DepartmentManagementForm.Designer.cs - עיצוב טופס ניהול מחלקות
using System.Windows.Forms;

namespace UniversityApp
{
    partial class DepartmentManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewDepartments;
        private Button buttonAddDepartment;
        private Button buttonRemoveDepartment;
        private TextBox textBoxDepartmentName;
        private Label labelDepartmentName;

        private void InitializeComponent()
        {
            this.listViewDepartments = new ListView();
            this.buttonAddDepartment = new Button();
            this.buttonRemoveDepartment = new Button();
            this.textBoxDepartmentName = new TextBox();
            this.labelDepartmentName = new Label();

            this.SuspendLayout();

            // listViewDepartments
            this.listViewDepartments.Location = new System.Drawing.Point(12, 12);
            this.listViewDepartments.Size = new System.Drawing.Size(460, 200);

            // buttonAddDepartment
            this.buttonAddDepartment.Text = "Add Department";
            this.buttonAddDepartment.Location = new System.Drawing.Point(12, 300);
            this.buttonAddDepartment.Click += new System.EventHandler(this.buttonAddDepartment_Click);

            // buttonRemoveDepartment
            this.buttonRemoveDepartment.Text = "Remove Department";
            this.buttonRemoveDepartment.Location = new System.Drawing.Point(150, 300);
            this.buttonRemoveDepartment.Click += new System.EventHandler(this.buttonRemoveDepartment_Click);

            // textBoxDepartmentName
            this.textBoxDepartmentName.Location = new System.Drawing.Point(12, 230);
            this.textBoxDepartmentName.Size = new System.Drawing.Size(200, 20);

            // labelDepartmentName
            this.labelDepartmentName.Text = "Department Name:";
            this.labelDepartmentName.Location = new System.Drawing.Point(12, 210);

            // DepartmentManagementForm
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.listViewDepartments);
            this.Controls.Add(this.buttonAddDepartment);
            this.Controls.Add(this.buttonRemoveDepartment);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.labelDepartmentName);
            this.ResumeLayout(false);
        }
    }
}
