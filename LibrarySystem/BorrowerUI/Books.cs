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
    public partial class Books : Form
    {
        private string connectionString;
        private int book_id;

        private DataHelper data;
        private Borrower borrower;

        private string[] bookDetails;

        public Books(int book_id, Borrower borrower)
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            this.book_id = book_id;

            this.borrower = borrower;
            data = new DataHelper(connectionString);
            bookDetails = data.getBookDetails(this.book_id);
        }

        private void Books_Load(object sender, EventArgs e)
        {
            lblTitle.Text = bookDetails[1];
            lblAuthor.Text = $"by {bookDetails[2]}";
            lblCopiesBorrowed.Text = $"Borrowed {1} copies";

            // TODO
            // This should be realistic
            lblBorrowDate.Text = "March 31, 2023";
            lblReturnDate.Text = "April 05, 2023";
        }

        private void BtnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            data.updateBookStatus(this.book_id.ToString(), "1");
            this.Close();

            // Show updates tot the Borrower UI
            borrower.lblUpdateMessage.Visible = true;
            borrower.lblUpdateMessage.Height = 31;
            borrower.tmHideMessage.Enabled = true;
        }
    }
}
