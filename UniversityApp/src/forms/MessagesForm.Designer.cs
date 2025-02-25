namespace UniversityApp
{
    partial class MessagesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderSender;
        private System.Windows.Forms.ColumnHeader columnHeaderContent;
        private System.Windows.Forms.ColumnHeader columnHeaderImportance;

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
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSender = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderContent = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderImportance = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listViewMessages
            // 
            this.listViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderSender,
            this.columnHeaderContent,
            this.columnHeaderImportance});
            this.listViewMessages.Location = new System.Drawing.Point(12, 12);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(776, 426);
            this.listViewMessages.TabIndex = 0;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 120;
            // 
            // columnHeaderSender
            // 
            this.columnHeaderSender.Text = "Sender";
            this.columnHeaderSender.Width = 120;
            // 
            // columnHeaderContent
            // 
            this.columnHeaderContent.Text = "Content";
            this.columnHeaderContent.Width = 400;
            // 
            // columnHeaderImportance
            // 
            this.columnHeaderImportance.Text = "Importance";
            this.columnHeaderImportance.Width = 100;
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewMessages);
            this.Name = "MessagesForm";
            this.Text = "MessagesForm";
            this.ResumeLayout(false);
        }
    }
}
