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
        private readonly BookRepository book;
        private readonly BorrowerRepository borrower;

        public static int borrowerId;
        public static int transactionId;


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
                    book.loadBorrowed(borrowerId);
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

                transactionId = Int32.Parse(row.Cells["Transaction ID"].Value.ToString());

                Book bookDetails = new Book(this);
                bookDetails.ShowDialog();

                //Load borrowed books when the dialog is closed
                //dataView.displayBorrowedBooks();
            }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            string newFirstName = txtFirstname.Text.Trim();
            string newLastName = txtLastname.Text.Trim();
            string newUsername = txtUsername.Text.Trim();

            if (!newFirstName.Equals(Login.firstName) || !newLastName.Equals(Login.lastName))
            {
                borrowerUI.hideErrorMessage();
                borrower.updateName(Login.currentUserId, newFirstName, newLastName);
                Login.firstName = newFirstName;
                Login.lastName = newLastName;

                borrowerUI.loadProfileUI();
            }

            else if (!newUsername.Equals(Login.username))
            {
                borrowerUI.hideErrorMessage();

                if (newUsername.Length < 6)
                {
                    borrowerUI.showInvalidUsernameMessage();
                }

                else
                {
                    borrowerUI.hideErrorMessage();
                    
                    if (borrower.checkIfExist(newUsername))
                    {
                        borrowerUI.showUsernameExistsMessage();
                    }

                    else
                    {
                        borrowerUI.hideErrorMessage();
                        borrower.updateUsername(Login.currentUserId, newUsername);
                        Login.username = newUsername;

                        borrowerUI.loadProfileUI();
                    }
                }
            }

        }

        private void BtnSavePass_Click(object sender, EventArgs e)
        {


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
