namespace WebBrowser.UI
{
    partial class History_Manager_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.histSearchBox = new System.Windows.Forms.TextBox();
            this.histSearchButton = new System.Windows.Forms.Button();
            this.histDeleteButton = new System.Windows.Forms.Button();
            this.histClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.Location = new System.Drawing.Point(92, 47);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(589, 394);
            this.historyListBox.TabIndex = 0;
            // 
            // histSearchBox
            // 
            this.histSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histSearchBox.Location = new System.Drawing.Point(92, 18);
            this.histSearchBox.Name = "histSearchBox";
            this.histSearchBox.Size = new System.Drawing.Size(292, 20);
            this.histSearchBox.TabIndex = 1;
            // 
            // histSearchButton
            // 
            this.histSearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.histSearchButton.Location = new System.Drawing.Point(399, 18);
            this.histSearchButton.Name = "histSearchButton";
            this.histSearchButton.Size = new System.Drawing.Size(75, 23);
            this.histSearchButton.TabIndex = 2;
            this.histSearchButton.Text = "search";
            this.histSearchButton.UseVisualStyleBackColor = true;
            this.histSearchButton.Click += new System.EventHandler(this.histSearchButton_Click);
            // 
            // histDeleteButton
            // 
            this.histDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.histDeleteButton.Location = new System.Drawing.Point(515, 18);
            this.histDeleteButton.Name = "histDeleteButton";
            this.histDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.histDeleteButton.TabIndex = 3;
            this.histDeleteButton.Text = "delete";
            this.histDeleteButton.UseVisualStyleBackColor = true;
            this.histDeleteButton.Click += new System.EventHandler(this.histDeleteButton_Click);
            // 
            // histClearButton
            // 
            this.histClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.histClearButton.Location = new System.Drawing.Point(606, 18);
            this.histClearButton.Name = "histClearButton";
            this.histClearButton.Size = new System.Drawing.Size(75, 23);
            this.histClearButton.TabIndex = 4;
            this.histClearButton.Text = "clear";
            this.histClearButton.UseVisualStyleBackColor = true;
            this.histClearButton.Click += new System.EventHandler(this.histClearButton_Click);
            // 
            // History_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.histClearButton);
            this.Controls.Add(this.histDeleteButton);
            this.Controls.Add(this.histSearchButton);
            this.Controls.Add(this.histSearchBox);
            this.Controls.Add(this.historyListBox);
            this.Name = "History_Manager_Form";
            this.Text = "History Manager";
            this.Load += new System.EventHandler(this.History_Manager_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.TextBox histSearchBox;
        private System.Windows.Forms.Button histSearchButton;
        private System.Windows.Forms.Button histDeleteButton;
        private System.Windows.Forms.Button histClearButton;
    }
}