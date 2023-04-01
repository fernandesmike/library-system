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
    public partial class Book : Form, IDisposable
    {
        private readonly string connection;

        private readonly BookRepository book;
        private readonly Borrower borrower;

        private List<string> bookDetails;

        private DateTime deadlineDate;
        private TimeSpan timeSpan;

        public Book(Borrower borrower)
        {
            InitializeComponent();
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            this.borrower = borrower;

            book = new BookRepository(connection);

            bookDetails = book.getTransactionDetails(Borrower.transactionId);
            updateUI();
        }

        private void BtnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();

            // Show updates to the Borrower UI
            borrower.lblUpdateMessage.Visible = true;
            borrower.lblUpdateMessage.Height = 31;
            borrower.tmHideMessage.Enabled = true;
        }

        private void updateUI()
        {
            lblTitle.Text = $"{bookDetails[0]}";
            lblAuthor.Text = $"by {bookDetails[1]}";
            lblCopiesBorrowed.Text = $"You borrowed {bookDetails[4]} copies";
            lblBorrowDate.Text = $"{bookDetails[2]}";
            lblReturnDate.Text = $"{bookDetails[3]}";
            lblDaysBorrowed.Text = $"You have {calculateDays()} days left to return the book";
            calculateDays();
        }

        private int calculateDays()
        {
            deadlineDate = DateTime.Parse(bookDetails[3].Split(' ')[0]);
            timeSpan = deadlineDate - DateTime.Today;

            return timeSpan.Days + 1;
        }

        private void Dispose()
        {
            bookDetails.Clear();
            bookDetails = null;
        }
    }
}
