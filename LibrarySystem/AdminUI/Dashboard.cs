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
using LibrarySystem.AdminUI;
using LibrarySystem.Repository;
using LibrarySystem.Enums;

namespace LibrarySystem
{
    public partial class Dashboard : Form
    {
        private DateTime today;
        private readonly string connection;

        // Helper classes & Enums
        private readonly DashboardUIHelper dashboardUI;
        private Add addUI;

        // Data repositories
        private readonly BookRepository book;
        private readonly BorrowerRepository borrower;

        // For book info
        // id is reusable (book or borrower ID)
        public static string id;
        public static string title;
        public static string author;
        public static string dateAdded;
        public static string quantities;

        // For borrower info
        public static string status;
        public static string firstName;
        public static string fullName;
        public static string lastName;
        public static string registrationDate;
        public static string username;

        // For navigating between pages
        public string context;

        public Dashboard()
        {
            InitializeComponent();

            // Data & Repositories
            //TODO: Change data source
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            book = new BookRepository(connection, dataGrid);
            borrower = new BorrowerRepository(connection, dataGrid);

            // Dashboard UI helper & Enums
            dashboardUI = new DashboardUIHelper(this);

            this.context = "borrowers";

            // Set default date to the date today
            today = DateTime.Today.Date;
            datePicker.MaxDate = today;
            datePicker.Value = today.Date;
        }

        public Dashboard(string context)
        {
            InitializeComponent();
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            book = new BookRepository(connection, dataGrid);
            borrower = new BorrowerRepository(connection, dataGrid);

            dashboardUI = new DashboardUIHelper(this);

            this.context = context;
            
            // Set default date to the date today
            today = DateTime.Today.Date;
            datePicker.MaxDate = today;
            datePicker.Value = today.Date;
        }

        private async void Home_Load(object sender, EventArgs e)
        {

            // Greet the user
            lblUser.Text = AdminLogin.currentUser;
            
            await Task.Run(() =>
            {
                this.Invoke((MethodInvoker) delegate
                {
                    if (context == "books")
                    {
                        dashboardUI.showBooksUI();

                        book.loadAll();
                        updateStatistics(context);
                    }

                    else if (context == "borrowers")
                    {
                        // Load the default dashboard UI
                        dashboardUI.showBorrowersUI();

                        // Populate the data grid everytime the form loads
                        borrower.loadAll();
                        updateStatistics(context);
                    }
                });
            });
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void BtnViewBorrowers_Click(object sender, EventArgs e)
        {
            // Update statistics
            borrower.loadAll();
            dashboardUI.showBorrowersUI();

            dataGrid.Visible = true;

            updateStatistics(context);
        }

        private void BtnViewBooks_Click(object sender, EventArgs e)
        {
            book.loadAll();
            dashboardUI.showBooksUI();

            updateStatistics(context);
        }

        private void BtnViewReports_Click(object sender, EventArgs e)
        {
            //TODO: Update reports
            //data.loadBorrowerReports(today.Date.ToString("yyyy-MM-dd"));
            dashboardUI.showReportsUI();
            updateStatistics(context);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (context == "borrowers")
            {
                borrower.search(txtSearch.Text.Trim());
            }
            else if (context == "books")
            {
                book.search(txtSearch.Text.Trim());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addUI = new Add(this, this.context);
            addUI.ShowDialog();

            if (context == "borrowers")
            {
                borrower.loadAll();
            }

            else if (context == "books")
            {
                book.loadAll();
            }
        }

        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {

            if (context == "borrowers")
            {
                borrower.loadAll();
            }
            else if (context == "books")
            {
                book.loadAll();
            }
        }

        private void RbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (context == "borrowers")
            {
                borrower.loadActive();
            }
            else if (context == "books")
            {
                book.loadActive();
            }
            else if (context == "reports")
            {
                //TODO: Update reports
                //data.loadBorrowerReports(today.Date.ToString("yyyy-MM-dd"));
            }

        }

        private void RbInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (context == "borrowers")
            {
                borrower.loadInactive();
            }
            else if (context == "books")
            {
                book.loadInactive();
            }
            else if (context == "reports")
            {
                //data.loadBookReports(today.Date.ToString("yyyy-MM-dd"));
            }
        }

        private void DataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (context == "borrowers")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                    // Get the currently selected data
                    id = row.Cells["Borrower ID"].Value.ToString();
                    firstName = row.Cells["Firstname"].Value.ToString();
                    fullName = row.Cells["Firstname"].Value.ToString() + " " + row.Cells["Lastname"].Value.ToString();
                    lastName = row.Cells["Lastname"].Value.ToString(); 
                    status = row.Cells["Status"].Value.ToString();
                    registrationDate = row.Cells["Registration date"].Value.ToString();
                    username = row.Cells["Username"].Value.ToString();


                    Details info = new Details(this.context);
                    this.Hide();
                    info.ShowDialog();
                }
            }

            else if (context == "books")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                    // Get the currently selected data
                    id = row.Cells["ID"].Value.ToString();
                    title = row.Cells["Book title"].Value.ToString();
                    author = row.Cells["Author"].Value.ToString();
                    status = row.Cells["Status"].Value.ToString();
                    dateAdded = row.Cells["Added last"].Value.ToString();
                    quantities = row.Cells["Total copies"].Value.ToString();

                    Details info = new Details(this.context);
                    this.Hide();
                    info.ShowDialog();
                }
            }
            
        }

        public void updateStatistics(string context)
        {
            if (context == "borrowers")
            {
                lblBorrowersCount.Text = Convert.ToString(borrower.count());
                lblActiveCount.Text = Convert.ToString(borrower.countByStatus((int)Status.ACTIVE));
                lblInactiveCount.Text = Convert.ToString(borrower.countByStatus((int)Status.INACTIVE));
            }

            else if (context == "books")
            {
                lblBorrowersCount.Text = Convert.ToString(book.count());
                lblActiveCount.Text = Convert.ToString(book.countByStatus((int)Status.ACTIVE));
                lblInactiveCount.Text = Convert.ToString(book.countByStatus((int)Status.INACTIVE));
            }

            else if (context == "reports")
            {
                //TODO: Update reports
                //lblBorrowersCount.Text = Convert.ToString(data.countBorrowers());
                //lblActiveCount.Text = Convert.ToString(data.countBooks());
                //lblInactiveCount.Text = Convert.ToString(data.countBooksToday(today.Date.ToString("yyyy-MM-dd")) + data.countBorrowersToday(today.Date.ToString("yyyy-MM-dd")));
            }
        }

        public void showQueryMessage(int status, string action)
        {
            if (this.context == "borrowers")
            {
                dashboardUI.borrowerQueryMessage(action, status, Dashboard.firstName);
            }

            else if (this.context == "books")
            {
                dashboardUI.bookQueryMessage(action, status, Dashboard.title);
            }
        }

        // Method to automatically hide query messages
        private void TmHideMessage_Tick(object sender, EventArgs e)
        {
            lblUpdateMessage.Visible = false;
            lblUpdateMessage.Height = 1;
            tmHideMessage.Enabled = false;
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            //lblBorrowersCount.Text = Convert.ToString(data.countBorrowersToday(datePicker.Value.Date.ToString("yyyy-MM-dd")));
            //lblActiveCount.Text = Convert.ToString(data.countBooksToday(datePicker.Value.Date.ToString("yyyy-MM-dd")));
            //lblInactiveCount.Text = Convert.ToString(data.countBooksToday(datePicker.Value.Date.ToString("yyyy-MM-dd")) + data.countBorrowersToday(datePicker.Value.Date.ToString("yyyy-MM-dd")));
            //TODO: Update reports
            if (rbActive.Checked)
            {
                //data.loadBorrowerReports(datePicker.Value.Date.ToString("yyyy-MM-dd"));

            }

            else if (rbInactive.Checked)
            {
                //data.loadBookReports(datePicker.Value.Date.ToString("yyyy-MM-dd"));
            }
        }
    }
}
