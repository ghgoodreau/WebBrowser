namespace WebBrowser.UI
{
    partial class Bookmark_Manager_Form
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
            this.bookmarkListBox = new System.Windows.Forms.ListBox();
            this.bookSearchTextBox = new System.Windows.Forms.TextBox();
            this.bookSearchButton = new System.Windows.Forms.Button();
            this.bookDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookmarkListBox
            // 
            this.bookmarkListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookmarkListBox.FormattingEnabled = true;
            this.bookmarkListBox.Location = new System.Drawing.Point(67, 67);
            this.bookmarkListBox.Name = "bookmarkListBox";
            this.bookmarkListBox.Size = new System.Drawing.Size(653, 381);
            this.bookmarkListBox.TabIndex = 0;
            // 
            // bookSearchTextBox
            // 
            this.bookSearchTextBox.Location = new System.Drawing.Point(67, 41);
            this.bookSearchTextBox.Name = "bookSearchTextBox";
            this.bookSearchTextBox.Size = new System.Drawing.Size(440, 20);
            this.bookSearchTextBox.TabIndex = 1;
            // 
            // bookSearchButton
            // 
            this.bookSearchButton.Location = new System.Drawing.Point(545, 39);
            this.bookSearchButton.Name = "bookSearchButton";
            this.bookSearchButton.Size = new System.Drawing.Size(75, 23);
            this.bookSearchButton.TabIndex = 2;
            this.bookSearchButton.Text = "search";
            this.bookSearchButton.UseVisualStyleBackColor = true;
            this.bookSearchButton.Click += new System.EventHandler(this.bookSearchButton_Click);
            // 
            // bookDeleteButton
            // 
            this.bookDeleteButton.Location = new System.Drawing.Point(645, 39);
            this.bookDeleteButton.Name = "bookDeleteButton";
            this.bookDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.bookDeleteButton.TabIndex = 3;
            this.bookDeleteButton.Text = "delete";
            this.bookDeleteButton.UseVisualStyleBackColor = true;
            this.bookDeleteButton.Click += new System.EventHandler(this.bookDeleteButton_Click);
            // 
            // Bookmark_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookDeleteButton);
            this.Controls.Add(this.bookSearchButton);
            this.Controls.Add(this.bookSearchTextBox);
            this.Controls.Add(this.bookmarkListBox);
            this.Name = "Bookmark_Manager_Form";
            this.Text = "Bookmark Manager";
            this.Load += new System.EventHandler(this.Bookmark_Manager_Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bookmarkListBox;
        private System.Windows.Forms.TextBox bookSearchTextBox;
        private System.Windows.Forms.Button bookSearchButton;
        private System.Windows.Forms.Button bookDeleteButton;
    }
}