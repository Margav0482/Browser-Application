using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Drawing;
using System.Linq;
using BrowserApplication.Forms;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using CefSharp.DevTools.Database;
using CefSharp.DevTools.Network;

namespace BrowserApplication
{
    public partial class MainWindow : Form
    {
        public string url;
        public string googlequery = "http://";
        public HttpClient client = new HttpClient();
        public WebClient webClient = new WebClient();

        public void updatebookmarkstab(string item)
        {
            favouritesToolStripMenuItem.DropDownItems.Add(item);

        }
        public MainWindow()
        {
            //Properties.Settings.Default.BookmarksList.Clear(); //Dev Purpose
            InitializeComponent();
            statusLabel.ResetText();
            webBrowser1.Visible = false;
            favouritesToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(dropDown_Click);
            changeHomePageURLTextBox.TextChanged += ChangeHomePageURLTextBox_TextChanged;
        }

        private void ChangeHomePageURLTextBox_TextChanged(object sender, EventArgs e)
        {
            var msg = changeHomePageURLTextBox.Text;
            Properties.Settings.Default.HomePageURL = msg;
            Properties.Settings.Default.Save();
        }

        public async void getHttpRequest()
        {
            contentBox.Visible = true;
            webBrowser1.Visible = false;
            url = inputUrlBox.Text.ToLower();
            //MessageBox.Show((new Uri(url).Scheme == Uri.UriSchemeHttp).ToString());

            try
            {
            Uri myuri;
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute) && (new Uri(url).Scheme == Uri.UriSchemeHttp))
            {
                myuri = new Uri(inputUrlBox.Text.ToLower());
            }
            else
            {
                myuri = new Uri("http://" + inputUrlBox.Text.ToLower());
            }

            statusLabel.ResetText();
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(myuri);
            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();

                //GET REQUEST:
                if (response.StatusCode.ToString() == "OK")
                {
                    var res = await client.GetStringAsync(myuri.ToString());
                    contentBox.Text = res;

                    //STATUS CODE
                    statusLabel.Text += "STATUS: " + ((int)response.StatusCode).ToString();
                }
            }
            catch (Exception ex)
            {
                contentBox.Text = ex.Message;
                statusLabel.Text += "STATUS: 404";
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
                    var name = item.Split(',')[1].ToString();
                    if(name != "null")
                    {
                        favouritesToolStripMenuItem.DropDownItems.Add(name);
                    }
                    else
                    {
                        favouritesToolStripMenuItem.DropDownItems.Add(linkname);
                    }
                }
            }
            changeHomePageURLTextBox.Text = Properties.Settings.Default.HomePageURL;
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
                contentBox.Visible = false;
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
                    contentBox.Visible = true;
                    contentBox.Text = ex.Message;
                }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void dropDown_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            var itemSelected = e.ClickedItem.Text;
            foreach (string item in Properties.Settings.Default.BookmarksList)
            {
                var linkname = item.Split(',')[0].ToString();
                var name = item.Split(',')[1].ToString();
                if(itemSelected == name)
                {
                    itemSelected = linkname;
                }
            }

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
                            var name = bookmark.Split(',')[1].ToString();
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
            form.ShowDialog();            
        }

        private async void homeButton_Click(object sender, EventArgs e)
        {
            contentBox.Visible = true;
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
                    contentBox.Text = res;

                    //STATUS CODE
                    statusLabel.Text += "STATUS: " + ((int)response.StatusCode).ToString();
                }
            }
            catch (Exception ex)
            {
                contentBox.Text = ex.Message;
            }
        }

        private void homePageURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void favouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void miscToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeHomePageURLTextBox_Click(object sender, EventArgs e)
        {

        }


        private async void bulkDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openbulkFile.ShowDialog();
            openbulkFile.Title = "Bulk.txt";
            openbulkFile.Filter = "TXT files|*.txt";
            if (dr == DialogResult.OK)
            {
                List<string> finalres = new List<string>();
                string fileName = openbulkFile.FileName;
                try
                {
                    string statuscode;
                    string bytes;
                    string url;
                    string code;
                    var lines = File.ReadLines(fileName);
                   
                    foreach (var line in lines)
                    {
                        url = line;
                        Uri uriResult;
                        bool isUri = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                            && uriResult.Scheme == Uri.UriSchemeHttp;
                        if (isUri)
                        {
                            Uri myuri = new Uri(url.ToString());
                            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(myuri);
                            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                            statuscode = ((int)response.StatusCode).ToString();

                            bytes = await client.GetStringAsync(myuri.ToString());

                            code = statuscode + " [" + bytes + "] " + url;

                            finalres.Add(code);
                        }
                        else
                        {
                            MessageBox.Show("Please provide header in file i.e 'http://'");
                        }
                        
                    }
                    String[] str = finalres.ToArray();
                    contentBox.Text = String.Join("\n", finalres);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}