namespace BrowserApplication.Forms.BookmarkFunctions
{
    partial class RemoveBookmarkWindow
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
            this.saveButon = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.Label();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButon
            // 
            this.saveButon.Location = new System.Drawing.Point(148, 83);
            this.saveButon.Name = "saveButon";
            this.saveButon.Size = new System.Drawing.Size(75, 23);
            this.saveButon.TabIndex = 9;
            this.saveButon.Text = "Remove";
            this.saveButon.UseVisualStyleBackColor = true;
            this.saveButon.Click += new System.EventHandler(this.saveButon_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(51, 48);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(171, 20);
            this.nameTextbox.TabIndex = 7;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(14, 15);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(30, 13);
            this.linkLabel.TabIndex = 6;
            this.linkLabel.Text = "Link:";
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(51, 12);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(171, 20);
            this.linkTextBox.TabIndex = 5;
            // 
            // RemoveBookmarkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 118);
            this.Controls.Add(this.saveButon);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.linkTextBox);
            this.Name = "RemoveBookmarkWindow";
            this.Text = "Remove Bookmark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButon;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.TextBox linkTextBox;
    }
}