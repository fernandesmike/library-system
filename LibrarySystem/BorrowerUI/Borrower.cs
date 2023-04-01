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
    public partial class Borrower : Form
    {
        private readonly string connection;

        // Data repositories & UI helpers
        private readonly BorrowerUIHelper borrowerUI;
        private readonly BorrowerRepository borrower;
        private readonly BookRepository book;

        public static int borrowerId;
        public static string bookId;
        public static string bookTitle;
        public static string bookAuthor;
        public static string bookCopies;
        public static string bookCopiesBorrowed;


        public Borrower()
        {
            InitializeComponent();
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            book = new BookRepository(connection, dataGrid);
            borrower = new BorrowerRepository(connection, dataGrid);

            borrowerUI = new BorrowerUIHelper(this);
            borrowerId = Login.currentUserId;
        }

        private async void Borrower_Load(object sender, EventArgs e)
        {
            lblUser.Text = Login.currentUser;

            // Understand this thing ASAP
            await Task.Run(() => 
            {
                this.Invoke((MethodInvoker) delegate
                {
                    borrowerUI.loadHomeUI();
                    //TODO: Load borrowed books
                    book.loadBorrowed();
                });
            });
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            BorrowBook borrow = new BorrowBook();
            this.Hide();
            borrow.ShowDialog();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            borrowerUI.loadHomeUI();
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            borrowerUI.loadProfileUI();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                bookId = row.Cells["ID"].Value.ToString();
                bookTitle = row.Cells["Book title"].Value.ToString();
                bookAuthor = row.Cells["Author"].Value.ToString();
                bookCopies = row.Cells["Available copeis"].Value.ToString();

                //Books bookDetails = new Books(data.getBookID(bookTitle, bookAuthor), this);
                //bookDetails.ShowDialog();

                //Load borrowed books
                //dataView.displayBorrowedBooks();
            }
        }

        private void TmHideMessage_Tick(object sender, EventArgs e)
        {
            lblUpdateMessage.Visible = false;
            lblUpdateMessage.Height = 1;
            tmHideMessage.Enabled = false;
        }

        private void BtnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
