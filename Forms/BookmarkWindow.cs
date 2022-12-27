using BrowserApplication.Forms.BookmarkFunctions;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BrowserApplication.Forms
{
    public partial class BookmarkWindow : Form
    {

        public string passedinputurl;
        public string passedinputname;
        public BookmarkWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            dataGridView.CellEndEdit += new DataGridViewCellEventHandler(editDetector);
        }
        private void editDetector(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = e.RowIndex;
            var colindex = e.ColumnIndex;

            if ((dataGridView.Rows[rowindex].Cells[1].Value != null) && (dataGridView.Rows[rowindex].Cells[1].Value.ToString() != "null"))
            {
                var name = dataGridView.Rows[rowindex].Cells[colindex].Value.ToString();
                var link = dataGridView.Rows[rowindex].Cells[0].Value.ToString();

                Properties.Settings.Default.BookmarksList.RemoveAt(rowindex);
                Properties.Settings.Default.Save();
                Properties.Settings.Default.BookmarksList.Insert(rowindex, link + "," + name);
                Properties.Settings.Default.Save();
            }
        }


        public void ClearData() {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
        }
        public void DataSetup()
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            DataGridViewTextBoxColumn linkCol = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Link",
                HeaderText = "Link",
                DataPropertyName = "Link",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name",

            };

            dataGridView.Columns.Add(linkCol);
            dataGridView.Columns.Add(nameCol);

            foreach (string item in Properties.Settings.Default.BookmarksList)
            {
                var index = Properties.Settings.Default.BookmarksList.IndexOf(item);
                var favCollectionName = Properties.Settings.Default.BookmarksList[index];
                var link = favCollectionName.Split(',')[0].ToString();
                var name = favCollectionName.Split(',')[1].ToString();
                var i = this.dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = link;
                dataGridView.Rows[i].Cells[1].Value = name;
            }
        }


        private void FavouritesWindow_Load(object sender, EventArgs e)
        {
            try {

                DataSetup();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            AddBookmarkWindow form = new AddBookmarkWindow();
            form.ShowDialog(this);

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count == 1) {
                var rowselectedindex = this.dataGridView.SelectedRows[0].Index;
                dataGridView.Rows.RemoveAt(rowselectedindex);

                Properties.Settings.Default.BookmarksList.RemoveAt(rowselectedindex);
                Properties.Settings.Default.Save();
            }
            else
            {
                RemoveBookmarkWindow form = new RemoveBookmarkWindow();
                form.ShowDialog(this);
            }
            
        }

        
        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            MessageBox.Show("Bookmarks Saved & Closed!");
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BookmarksList.Clear();
        }
    }
}
