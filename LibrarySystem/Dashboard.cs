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

        // For book info
        public static string id;
        public static string title;
        public static string author;

        // For borrower info
        public static string status;
        public static string firstName;
        public static string fullName;

        // For navigating between pages
        public string context;

        public Dashboard()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            data = new DataHelper(connectionString, dataGrid);
            dashboardUI = new DashboardUIHelper(this);
        }

        private void Home_Load(object sender, EventArgs e)
        {

            // Load the default dashboard UI
            dashboardUI.showBorrowersUI();

            // Greet the user
            lblUser.Text = Login.currentUser;

            // Populate the data grid everytime the form loads
            data.loadBorrowers();

            lblBorrowersCount.Text = Convert.ToString(data.countBorrowers());
            lblActiveCount.Text = Convert.ToString(data.countBorrowers("active"));
            lblInactiveCount.Text = Convert.ToString(data.countBorrowers("inactive"));

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
            data.loadBorrowers();
            dashboardUI.showBorrowersUI();

            dataGrid.Visible = true;
        }

        private void BtnViewBooks_Click(object sender, EventArgs e)
        {
            data.loadAllBooks();
            dashboardUI.showBooksUI();
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
            if(context == "borrowers")
            {
                BorrowerInfo info = new BorrowerInfo();
                this.Hide();
                info.ShowDialog();
            }
        }

        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {
            data.loadBorrowers();
        }

        private void RbActive_CheckedChanged(object sender, EventArgs e)
        {
            data.loadBorrowers(rbActive.Text.ToLower());
        }

        private void RbInactive_CheckedChanged(object sender, EventArgs e)
        {
            data.loadBorrowers(rbInactive.Text.ToLower());
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the currently selected row
            DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

            if (e.RowIndex >= 0)
            {
                // Get the currently selected data
                id = row.Cells["Borrower ID"].Value.ToString();
                firstName = row.Cells["Firstname"].Value.ToString();
                fullName = row.Cells["Firstname"].Value.ToString() + " " + row.Cells["Lastname"].Value.ToString();
                status = row.Cells["Status"].Value.ToString();

                BorrowerInfo info = new BorrowerInfo();
                this.Hide();
                info.ShowDialog();
            }
        }
    }
}
