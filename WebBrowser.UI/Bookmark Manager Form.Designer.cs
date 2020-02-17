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
            this.SuspendLayout();
            // 
            // bookmarkListBox
            // 
            this.bookmarkListBox.FormattingEnabled = true;
            this.bookmarkListBox.Location = new System.Drawing.Point(69, 25);
            this.bookmarkListBox.Name = "bookmarkListBox";
            this.bookmarkListBox.Size = new System.Drawing.Size(653, 381);
            this.bookmarkListBox.TabIndex = 0;
            // 
            // Bookmark_Manager_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookmarkListBox);
            this.Name = "Bookmark_Manager_Item";
            this.Text = "Bookmark Manager";
            this.Load += new System.EventHandler(this.Bookmark_Manager_Item_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookmarkListBox;
    }
}