namespace UniversityApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button buttonSettings;

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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            welcomeLabel = new Label();
            buttonSettings = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(40, 52);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Enter your username";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(40, 139);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Enter your password";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // button1
            // 
            button1.Location = new Point(40, 228);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(196, 57);
            button1.TabIndex = 2;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(40, 290);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(196, 59);
            button2.TabIndex = 5;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(40, 170);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Student";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(154, 170);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(84, 24);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Lecturer";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(40, 200);
            checkBox3.Margin = new Padding(2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(89, 24);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Assistant";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(154, 200);
            checkBox4.Margin = new Padding(2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(111, 24);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "DepartmentHead";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(147, 96);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 370);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 13);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 8;
            label1.Text = "Enter your username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 97);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 9;
            label2.Text = "Enter your password:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 14F);
            welcomeLabel.Location = new Point(147, 31);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(445, 32);
            welcomeLabel.TabIndex = 10;
            welcomeLabel.Text = "Welcome to the University Login System";
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(593, 441);
            buttonSettings.Margin = new Padding(2);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(196, 48);
            buttonSettings.TabIndex = 11;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            Controls.Add(welcomeLabel);
            Controls.Add(buttonSettings);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "University App";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ContextMenuStrip contextMenuStrip1;
    }
}
