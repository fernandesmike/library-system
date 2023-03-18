using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BorrowBook : Form
    {
        private string connectionString;

        private BorrowBookUIHelper borrowerUI;
        private DataHelper data;
        private DataViews dataView;

        // Book information
        String id, title, author;

        public BorrowBook()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            borrowerUI = new BorrowBookUIHelper(this);
            data = new DataHelper(connectionString, dataGrid);
            dataView = new DataViews(connectionString, dataGrid);
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            dataView.displayBooks();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Borrower returnToHome = new Borrower();
            this.Close();
            returnToHome.Show();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                // Get the currently selected data
                id = row.Cells["ID"].Value.ToString();
                title = row.Cells["Book title"].Value.ToString();
                author = row.Cells["Author"].Value.ToString();

                borrowerUI.displayBookToBorrow(id, title, author);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            data.searchBooks(txtSearch.Text.Trim(), "1");
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            // TODO:
            // Update the status of the book
            // And add the book to the borrower's collection
            data.updateBookStatus(id, "0");
            dataView.displayBooks();
            borrowerUI.showMessage(title);
            borrowerUI.resetUI();
        }

        private void TmHideMessage_Tick(object sender, EventArgs e)
        {
            lblUpdateMessage.Visible = false;
            lblUpdateMessage.Height = 1;
            tmHideMessage.Enabled = false;
        }
    }
}
