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
using LibrarySystem.Class;

namespace LibrarySystem
{
    public partial class Add : Form
    {
        private DataHelper data;
        private AddUIHelper addUI;
        private Dashboard dashboard;
        private DashboardUIHelper dashboardUI;

        private string connectionString;
        private string context;

        public Add(Dashboard dashboard, string context)
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            this.context = context;
            this.dashboard = dashboard;

            addUI = new AddUIHelper(this);

            if (context == "borrowers")
            {
                addUI.loadAddBorrowerUI();

            }

            else if (context == "books")
            {
                addUI.loadAddBookUI();
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            data = new DataHelper(connectionString);
            dashboardUI = new DashboardUIHelper(this.dashboard);
        }

        private void BtnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int queryStatus;

            if (validateFields())
            {
                addUI.hideErrorMessage();

                if (context == "borrowers")
                {
                    // TODO
                    // Check borrower already exists
                    // Convert received input data and retrieved database data to lowerCase to avoid capitalization bug
                    // Same goes with books

                    queryStatus = data.addBorrower(txtFirst.Text.Trim(), txtSecond.Text.Trim());
                    dashboardUI.showBorrowersUI();
                    Dashboard.firstName = txtFirst.Text.Trim();
                    dashboard.showQueryMessage(queryStatus, "adde");
                }

                else if (context == "books")
                {
                    queryStatus = data.addBook(txtFirst.Text.Trim(), txtSecond.Text.Trim());
                    dashboardUI.showBooksUI();
                    Dashboard.title = txtFirst.Text.Trim();
                    dashboard.showQueryMessage(queryStatus, "adde");
                }

                this.Close();
            }

            else
            {
                addUI.showErrorMessage();
            }
        }

        private bool validateFields()
        {
            bool valid = false;

            string first = txtFirst.Text.Trim();
            string second = txtSecond.Text.Trim();

            if ((first == "" && second == "") || (first == "" || second == ""))
            {
                valid = false;
            }

            else
            {
                valid = true;
            }

            return valid;
        }
    }
}
