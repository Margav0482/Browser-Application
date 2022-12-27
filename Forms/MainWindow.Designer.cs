namespace BrowserApplication
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.inputUrlBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.homePageURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bulkDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.favButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputUrlBox
            // 
            this.inputUrlBox.Location = new System.Drawing.Point(74, 34);
            this.inputUrlBox.Name = "inputUrlBox";
            this.inputUrlBox.Size = new System.Drawing.Size(603, 20);
            this.inputUrlBox.TabIndex = 1;
            this.inputUrlBox.TextChanged += new System.EventHandler(this.inputUrlBox_TextChanged);
            this.inputUrlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(665, 518);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(12, 59);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(56, 23);
            this.getButton.TabIndex = 6;
            this.getButton.Text = "GET";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.miscToolStripMenuItem,
            this.favouritesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renderTabToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // renderTabToolStripMenuItem
            // 
            this.renderTabToolStripMenuItem.Name = "renderTabToolStripMenuItem";
            this.renderTabToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.renderTabToolStripMenuItem.Text = "Render";
            this.renderTabToolStripMenuItem.Click += new System.EventHandler(this.renderTabToolStripMenuItem_Click);
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateFavouritesToolStripMenuItem,
            this.toolStripSeparator1,
            this.homePageURLToolStripMenuItem,
            this.toolStripSeparator2,
            this.bulkDownloadToolStripMenuItem});
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.miscToolStripMenuItem.Text = "Misc";
            // 
            // updateFavouritesToolStripMenuItem
            // 
            this.updateFavouritesToolStripMenuItem.Name = "updateFavouritesToolStripMenuItem";
            this.updateFavouritesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.updateFavouritesToolStripMenuItem.Text = "Update Favourites";
            this.updateFavouritesToolStripMenuItem.Click += new System.EventHandler(this.updateFavouritesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // homePageURLToolStripMenuItem
            // 
            this.homePageURLToolStripMenuItem.Name = "homePageURLToolStripMenuItem";
            this.homePageURLToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.homePageURLToolStripMenuItem.Text = "Change Home Page URL";
            this.homePageURLToolStripMenuItem.Click += new System.EventHandler(this.homePageURLToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // bulkDownloadToolStripMenuItem
            // 
            this.bulkDownloadToolStripMenuItem.Name = "bulkDownloadToolStripMenuItem";
            this.bulkDownloadToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.bulkDownloadToolStripMenuItem.Text = "Bulk Download";
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.favouritesToolStripMenuItem.Text = "Favourites";
            this.favouritesToolStripMenuItem.Click += new System.EventHandler(this.favouritesToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 88);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(665, 518);
            this.webBrowser1.TabIndex = 10;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(86, 64);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(83, 13);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "STATUS CODE";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // favButton
            // 
            this.favButton.BackColor = System.Drawing.SystemColors.Control;
            this.favButton.BackgroundImage = global::BrowserApplication.Properties.Resources.star;
            this.favButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.favButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.favButton.Location = new System.Drawing.Point(43, 32);
            this.favButton.Name = "favButton";
            this.favButton.Size = new System.Drawing.Size(25, 23);
            this.favButton.TabIndex = 11;
            this.favButton.UseVisualStyleBackColor = false;
            this.favButton.Click += new System.EventHandler(this.favButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.Control;
            this.homeButton.BackgroundImage = global::BrowserApplication.Properties.Resources.home;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homeButton.Location = new System.Drawing.Point(12, 32);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(25, 23);
            this.homeButton.TabIndex = 4;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 618);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.favButton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.inputUrlBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputUrlBox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem homePageURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkDownloadToolStripMenuItem;
        private System.Windows.Forms.Button favButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateFavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
    }
}

