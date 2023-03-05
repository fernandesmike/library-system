using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem
{
    public partial class HomeScreen : Form
    {
        private string connectionString;
        private DataHelper data;
        public HomeScreen()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // Instantiate the data helper
            data = new DataHelper(connectionString, dataGrid);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            // Greet the user
            lblUser.Text = "Welcome, " + Login.currentUser + "!";

            // Populate the data grid everytime the form loads
            data.loadAvailableBooks();
            
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, title, author;

            // Get the currently selected row
            DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];


            if (e.RowIndex >= 0)
            {
                // Buttons
                btnBorrowBook.Enabled = true;

                // Get the currently selected data
                id = row.Cells["ID"].Value.ToString();
                title = row.Cells["Book title"].Value.ToString();
                author = row.Cells["Author"].Value.ToString();

                lblBookID.Text = "Book ID: " + id;
                lblBookTitle.Text = title;
                lblAuthor.Text = "by " + author;

                lblBorrowMessage.Visible = false;
            }
            else
            {
                btnBorrowBook.Enabled = false;

                lblBookID.Text = "Book ID: -";
                lblBookTitle.Text = "Please select a book";
                lblAuthor.Text = "-";

                lblBorrowMessage.Visible = true;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            btnBorrowBook.Enabled = false;

            lblBookID.Text = "Book ID: -";
            lblBookTitle.Text = "Please select a book";
            lblAuthor.Text = "-";

            lblBorrowMessage.Visible = true;

            string search = txtSearch.Text.Trim();

            data.searchBooks(search);

        }
    }
}
