namespace UniversityApp
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSendMessage;

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
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            listBoxResults = new ListBox();
            textBoxMessage = new TextBox();
            buttonSendMessage = new Button();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(94, 33);
            textBoxSearch.Margin = new Padding(2, 2, 2, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(161, 27);
            textBoxSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(259, 15);
            buttonSearch.Margin = new Padding(2, 2, 2, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(92, 45);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(94, 75);
            listBoxResults.Margin = new Padding(2, 2, 2, 2);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(257, 144);
            listBoxResults.TabIndex = 2;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(94, 239);
            textBoxMessage.Margin = new Padding(2, 2, 2, 2);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(257, 81);
            textBoxMessage.TabIndex = 3;
            // 
            // buttonSendMessage
            // 
            buttonSendMessage.Location = new Point(168, 336);
            buttonSendMessage.Margin = new Padding(2, 2, 2, 2);
            buttonSendMessage.Name = "buttonSendMessage";
            buttonSendMessage.Size = new Size(87, 53);
            buttonSendMessage.TabIndex = 4;
            buttonSendMessage.Text = "Send";
            buttonSendMessage.UseVisualStyleBackColor = true;
            buttonSendMessage.Click += buttonSendMessage_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 400);
            Controls.Add(buttonSendMessage);
            Controls.Add(textBoxMessage);
            Controls.Add(listBoxResults);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SearchForm";
            Text = "Search People";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
