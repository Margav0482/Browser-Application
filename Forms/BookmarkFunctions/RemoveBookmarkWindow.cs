using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserApplication.Forms.BookmarkFunctions
{
    public partial class RemoveBookmarkWindow : Form
    {
        public string linkinput;
        public string nameinput;
        public RemoveBookmarkWindow()
        {
            InitializeComponent();
        }

        private void saveButon_Click(object sender, EventArgs e)
        {
            linkinput = linkTextBox.Text;
            nameinput = nameTextbox.Text;

            bool isUri = Properties.Settings.Default.BookmarksList.Contains(linkinput + "," + nameinput);
            
            if (isUri)
            {
                Properties.Settings.Default.BookmarksList.Remove(linkinput + "," + nameinput);
                Properties.Settings.Default.Save();

                this.Close();
                MessageBox.Show("Removed!");
            }
            else
            {
                MessageBox.Show("That doesn't exists in bookmarks!");
            }
        }
    }
}
