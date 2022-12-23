using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Drawing;
using System.Linq;
using BrowserApplication.Forms;
using System.Collections.Generic;

namespace BrowserApplication
{
    public partial class MainWindow : Form
    {
        public string url;
        public string googlequery = "http://";
        public HttpClient client = new HttpClient();
        public WebClient webClient = new WebClient();
        
        public MainWindow()
        {
            //Properties.Settings.Default.BookmarksList.Clear(); //Dev Purpose
            InitializeComponent();
            statusLabel.ResetText();
            webBrowser1.Visible = false;
            favouritesToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(dropDown_Click);           
        }

        public async void getHttpRequest()
        {
            richTextBox1.Visible = true;
            webBrowser1.Visible = false;
            url = inputUrlBox.Text.ToString().ToLower();
            Uri myuri = new Uri(googlequery + inputUrlBox.Text.ToLower());
            statusLabel.ResetText();

            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(myuri);
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                //GET REQUEST:
                if (response.StatusCode.ToString() == "OK")
                {
                    var res = await client.GetStringAsync(myuri.ToString());
                    richTextBox1.Text = res;

                    //STATUS CODE
                    statusLabel.Text += "STATUS: " + ((int)response.StatusCode).ToString();
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }
        }

        private async void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Return && inputUrlBox.Text != "" && !webClient.IsBusy)
            {
                getHttpRequest();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BookmarksList != null)
            {
                foreach (string item in Properties.Settings.Default.BookmarksList)
                {
                    var linkname = item.Split(',')[0].ToString();
                    favouritesToolStripMenuItem.DropDownItems.Add(linkname);
                }
            }
        }


        private void inputUrlBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void getButton_Click(object sender, EventArgs e)
        {
            
            if (inputUrlBox.Text != "" && !webClient.IsBusy)
            {
                statusLabel.ResetText();
                getHttpRequest();

            }
        }

        private async void renderTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputUrlBox.Text != "" && !webClient.IsBusy)
            {
                webBrowser1.Visible = true;
                richTextBox1.Visible = false;
                try
                {
                    Uri myuri = new Uri(googlequery + inputUrlBox.Text.ToLower());
                    webClient.Encoding = Encoding.UTF8;
                    var data = await webClient.DownloadDataTaskAsync(myuri.ToString());

                    webBrowser1.Navigate(new Uri(myuri.ToString()));
                }
                catch (Exception ex)
                {
                    webBrowser1.Visible = false;
                    richTextBox1.Visible = true;
                    richTextBox1.Text = ex.Message;
                }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void dropDown_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            var itemSelected = e.ClickedItem.Text;
            if (itemSelected != null && !webClient.IsBusy)
            {
                inputUrlBox.Text = itemSelected;
                statusLabel.ResetText();
                getHttpRequest();
            }
  
        }

        private void favButton_Click(object sender, EventArgs e)
        {
            if(inputUrlBox.Text != "")
            {
                var item = inputUrlBox.Text.ToString();
                
                if(!favouritesToolStripMenuItem.DropDownItems.Cast<ToolStripMenuItem>().Any(x => x.Text == item))
                {
                    try {
                        Properties.Settings.Default.BookmarksList.Add(item + ",null");
                        Properties.Settings.Default.Save();
                        foreach (var bookmark in Properties.Settings.Default.BookmarksList) {
                            var link = bookmark.Split(',')[0].ToString();
                            favouritesToolStripMenuItem.DropDownItems.Add(link);
                        }
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Bookmark already exists!");
                }
            }
        }

        private void updateFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkWindow form = new BookmarkWindow();
            form.ShowDialog(this);
        }

        private async void homeButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            webBrowser1.Visible = false;
            url = Properties.Settings.Default.HomePageURL;
            inputUrlBox.Text = url;
            Uri myuri = new Uri(url.ToString());
            statusLabel.ResetText();

            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(myuri);
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                //GET REQUEST:
                if (response.StatusCode.ToString() == "OK")
                {
                    var res = await client.GetStringAsync(myuri.ToString());
                    richTextBox1.Text = res;

                    //STATUS CODE
                    statusLabel.Text += "STATUS: " + ((int)response.StatusCode).ToString();
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }
        }

        private void homePageURLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void favouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}