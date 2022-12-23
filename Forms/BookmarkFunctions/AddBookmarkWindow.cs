using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;

namespace BrowserApplication.Forms.BookmarkFunctions
{
    public partial class AddBookmarkWindow : Form
    {
        public string linkinput;
        public string nameinput;
        BookmarkWindow bookmarkform = new BookmarkWindow();


        public AddBookmarkWindow()
        {
            InitializeComponent();
        }

        private void AddBookmarkWindow_Load(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveButon_Click(object sender, EventArgs e)
        {
            linkinput = linkTextBox.Text;
            nameinput = nameTextbox.Text;
            Uri uriResult;
            bool isUri = Uri.TryCreate(linkinput, UriKind.Absolute, out uriResult)
                && uriResult.Scheme == Uri.UriSchemeHttp;
            
            if ((isUri) && (linkinput != null && linkinput.Length > 0) && (nameinput != null && nameinput.Length > 0))
            {
                Properties.Settings.Default.BookmarksList.Add(linkinput + "," + nameinput);
                Properties.Settings.Default.Save();

                this.Close();
                MessageBox.Show("Added!");
            }
            else
            {
                MessageBox.Show("Please give proper input!");
            }
            
        }
    }
}
