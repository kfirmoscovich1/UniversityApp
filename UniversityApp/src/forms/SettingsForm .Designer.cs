namespace UniversityApp
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RadioButton radioButtonLightMode;
        private System.Windows.Forms.RadioButton radioButtonDarkMode;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Panel panelMode;
        private System.Windows.Forms.Panel panelTextSize;

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
            radioButtonLightMode = new RadioButton();
            radioButtonDarkMode = new RadioButton();
            radioButtonSmall = new RadioButton();
            radioButtonMedium = new RadioButton();
            buttonApply = new Button();
            panelMode = new Panel();
            panelTextSize = new Panel();
            panelMode.SuspendLayout();
            panelTextSize.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonLightMode
            // 
            radioButtonLightMode.AutoSize = true;
            radioButtonLightMode.Location = new Point(13, 10);
            radioButtonLightMode.Name = "radioButtonLightMode";
            radioButtonLightMode.Size = new Size(106, 24);
            radioButtonLightMode.TabIndex = 0;
            radioButtonLightMode.TabStop = true;
            radioButtonLightMode.Text = "Light Mode";
            radioButtonLightMode.UseVisualStyleBackColor = true;
            // 
            // radioButtonDarkMode
            // 
            radioButtonDarkMode.AutoSize = true;
            radioButtonDarkMode.Location = new Point(13, 40);
            radioButtonDarkMode.Name = "radioButtonDarkMode";
            radioButtonDarkMode.Size = new Size(104, 24);
            radioButtonDarkMode.TabIndex = 1;
            radioButtonDarkMode.TabStop = true;
            radioButtonDarkMode.Text = "Dark Mode";
            radioButtonDarkMode.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmall
            // 
            radioButtonSmall.AutoSize = true;
            radioButtonSmall.Location = new Point(13, 10);
            radioButtonSmall.Name = "radioButtonSmall";
            radioButtonSmall.Size = new Size(67, 24);
            radioButtonSmall.TabIndex = 2;
            radioButtonSmall.TabStop = true;
            radioButtonSmall.Text = "Small";
            radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            radioButtonMedium.AutoSize = true;
            radioButtonMedium.Location = new Point(13, 40);
            radioButtonMedium.Name = "radioButtonMedium";
            radioButtonMedium.Size = new Size(85, 24);
            radioButtonMedium.TabIndex = 3;
            radioButtonMedium.TabStop = true;
            radioButtonMedium.Text = "Medium";
            radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(12, 212);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(94, 29);
            buttonApply.TabIndex = 5;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // panelMode
            // 
            panelMode.Controls.Add(radioButtonLightMode);
            panelMode.Controls.Add(radioButtonDarkMode);
            panelMode.Location = new Point(12, 12);
            panelMode.Name = "panelMode";
            panelMode.Size = new Size(200, 70);
            panelMode.TabIndex = 6;
            // 
            // panelTextSize
            // 
            panelTextSize.Controls.Add(radioButtonSmall);
            panelTextSize.Controls.Add(radioButtonMedium);
            panelTextSize.Location = new Point(12, 88);
            panelTextSize.Name = "panelTextSize";
            panelTextSize.Size = new Size(200, 70);
            panelTextSize.TabIndex = 7;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 307);
            Controls.Add(panelTextSize);
            Controls.Add(panelMode);
            Controls.Add(buttonApply);
            Name = "SettingsForm";
            Text = "Settings";
            panelMode.ResumeLayout(false);
            panelMode.PerformLayout();
            panelTextSize.ResumeLayout(false);
            panelTextSize.PerformLayout();
            ResumeLayout(false);
        }
    }
}
