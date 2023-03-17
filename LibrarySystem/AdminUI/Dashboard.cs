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
    public partial class Dashboard : Form
    {
        private string connectionString;

        // Helper classes
        private DataHelper data;
        private DashboardUIHelper dashboardUI;
        private Add addUI;

        // For book info
        // id is reusable (book or borrower ID)
        public static string id;
        public static string title;
        public static string author;

        // For borrower info
        public static string status;
        public static string firstName;
        public static string fullName;
        public static string lastName;

        // For navigating between pages
        public string context;

        public Dashboard()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            data = new DataHelper(connectionString, dataGrid);
            dashboardUI = new DashboardUIHelper(this);

            this.context = "borrowers";
        }

        public Dashboard(string context)
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            data = new DataHelper(connectionString, dataGrid);
            dashboardUI = new DashboardUIHelper(this);

            this.context = context;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Greet the user
            lblUser.Text = Login.currentUser;

            if (context == "books")
            {
                dashboardUI.showBooksUI();

                data.loadAllBooks();
                updateStatistics(context);
            }

            else if (context == "borrowers")
            {
                // Load the default dashboard UI
                dashboardUI.showBorrowersUI();

                // Populate the data grid everytime the form loads
                data.loadBorrowers();
                updateStatistics(context);
            }
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
            data.loadBorrowers();
            dashboardUI.showBorrowersUI();

            dataGrid.Visible = true;

            updateStatistics(context);
        }

        private void BtnViewBooks_Click(object sender, EventArgs e)
        {
            data.loadAllBooks();
            dashboardUI.showBooksUI();

            updateStatistics(context);
        }

        private void BtnViewReports_Click(object sender, EventArgs e)
        {
            dashboardUI.showReportsUI();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (context == "borrowers")
            {
                data.searchBorrowers(txtSearch.Text.Trim());
            }
            else if (context == "books")
            {
                data.searchBooks(txtSearch.Text.Trim());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addUI = new Add(this, this.context);
            addUI.ShowDialog();

            if (context == "borrowers")
            {
                data.loadBorrowers();
            }

            else if (context == "books")
            {
                data.loadAllBooks();
            }
        }

        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (context == "borrowers")
            {
                data.loadBorrowers();
            }
            else if (context == "books")
            {
                data.loadAllBooks();
            }
        }

        private void RbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (context == "borrowers")
            {
                data.loadBorrowers(rbActive.Text.ToLower());
            }
            else if (context == "books")
            {
                data.loadAvailableBooks();
            }
            
        }

        private void RbInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (context == "borrowers")
            {
                data.loadBorrowers(rbInactive.Text.ToLower());
            }
            else if (context == "books")
            {
                data.loadBorrowedBooks();
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
                    status = row.Cells["Available"].Value.ToString();

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
                lblBorrowersCount.Text = Convert.ToString(data.countBorrowers());
                lblActiveCount.Text = Convert.ToString(data.countBorrowers("active"));
                lblInactiveCount.Text = Convert.ToString(data.countBorrowers("inactive"));
            }
            else if (context == "books")
            {
                lblBorrowersCount.Text = Convert.ToString(data.countBooks());
                lblActiveCount.Text = Convert.ToString(data.countBooks("1"));
                lblInactiveCount.Text = Convert.ToString(data.countBooks("0"));
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

    }
}
