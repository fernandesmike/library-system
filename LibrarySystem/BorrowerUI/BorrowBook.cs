using LibrarySystem.Repository;
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
        private readonly string connection;

        // Data repository & UI Helpers
        private readonly BorrowBookUIHelper borrowerUI;
        private readonly BookRepository book;

        // Book information
        String id, title, author, copies;

        public BorrowBook()
        {
            InitializeComponent();
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            borrowerUI = new BorrowBookUIHelper(this);
            book = new BookRepository(connection, dataGrid);

        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            book.loadAvailable();
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
                copies = row.Cells["Available copies"].Value.ToString();

                borrowerUI.displayBookToBorrow(id, title, author, copies);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            book.search(txtSearch.Text.Trim());
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            // TODO:
            // Update the status of the book
            // And add the book to the borrower's collection
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
