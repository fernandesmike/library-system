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
        private readonly BorrowingRepository transaction;

        // Book information
        String title, author;
        int bookId, copies, copiesToBorrow;

        private readonly DateTime today;
        private readonly DateTime returnDate;

        public BorrowBook()
        {
            InitializeComponent();
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            borrowerUI = new BorrowBookUIHelper(this);
            book = new BookRepository(connection, dataGrid);
            transaction = new BorrowingRepository(connection, dataGrid);

            today = DateTime.Today;
            returnDate = today.AddDays(7);

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
                bookId = Int32.Parse(row.Cells["ID"].Value.ToString());
                title = row.Cells["Book title"].Value.ToString();
                author = row.Cells["Author"].Value.ToString();
                copies = Int32.Parse(row.Cells["Available copies"].Value.ToString());

                borrowerUI.displayBookToBorrow(bookId.ToString(), title, author, copies.ToString());
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

            if (validateQuantity(txtQuantities.Text.Trim(), copies))
            {
                copiesToBorrow = Int32.Parse(txtQuantities.Text.Trim());

                // Borrow the book 
                transaction.borrowBook(bookId, Borrower.borrowerId, today.ToString("yyyy-MM-d"), returnDate.ToString("yyyy-MM-d"), copiesToBorrow);
                book.decreaseQuantity(bookId, copiesToBorrow);

                borrowerUI.showMessage(title);
                borrowerUI.resetUI();

                // Requery to update the datagrid contents
                book.loadAvailable();
            }

        }

        private bool validateQuantity(string quantity, int availableCopies)
        {
            bool valid = false;
            int _quantity = 0;

            // Check if the specified quantity is actually a number
            if (int.TryParse(quantity, out _quantity))
            {
                borrowerUI.hideQuantityErrorMessage();


                // If it is, then check if it exceeds the maxium copy the current book has
                if(_quantity < 1 || _quantity > availableCopies)
                {
                    valid = false;
                    borrowerUI.showInvalidQuantityMessage(availableCopies);
                }
                else
                {
                    valid = true;
                    borrowerUI.hideQuantityErrorMessage();
                }
            }

            else
            {
                borrowerUI.showNotQuantityMessage();
            }

            return valid;
        }

        private void TmHideMessage_Tick(object sender, EventArgs e)
        {
            lblUpdateMessage.Visible = false;
            lblUpdateMessage.Height = 1;
            tmHideMessage.Enabled = false;
        }
    }
}
