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
using LibrarySystem.Repository;

namespace LibrarySystem
{
    public partial class Add : Form
    {
        // Data Repositories
        private readonly BookRepository book;
        private readonly BorrowerRepository borrower;

        // UI Helpers
        private readonly AddUIHelper addUI;
        private readonly Dashboard dashboard;
        private readonly DashboardUIHelper dashboardUI;


        private string connection;
        private string context;

        private DateTime today;

        public Add(Dashboard dashboard, string context)
        {
            InitializeComponent();
            //TODO: Change data source
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            this.context = context;
            this.dashboard = dashboard;

            dashboardUI = new DashboardUIHelper(this.dashboard);
            addUI = new AddUIHelper(this);

            today = DateTime.Today;

            book = new BookRepository(connection);
            borrower = new BorrowerRepository(connection);

        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (context == "borrowers")
            {
                addUI.loadAddBorrowerUI();

            }

            else if (context == "books")
            {
                addUI.loadAddBookUI();
            }
        }

        private void BtnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int queryStatus;

            string first = txtFirst.Text.Trim();
            string second = txtSecond.Text.Trim();
            string username = txtUsername.Text.Trim();
            int quantity = 1;

            if (validateFields())
            {
                addUI.hideErrorMessage();

                if (context == "borrowers")
                {
                    if (borrower.checkIfExist(username))
                    {
                        addUI.showErrorMessage();
                        addUI.showBorrowerExistMessage();
                    }

                    else
                    {
                        addUI.hideErrorMessage();

                        queryStatus = borrower.add(username, first, second, today.ToString("yyyy-MM-d"));
                        dashboardUI.showBorrowersUI();
                        Dashboard.firstName = txtFirst.Text.Trim();
                        dashboard.showQueryMessage(queryStatus, "adde");
                        dashboard.updateStatistics(this.context);

                        this.Close();
                    }
                }

                else if (context == "books")
                {
                    if (book.checkIfExist(first, second))
                    {
                        addUI.showErrorMessage();
                        addUI.showBookExistMessage();
                    }

                    else
                    {
                        addUI.hideErrorMessage();

                        if(int.TryParse(username, out quantity))
                        {
                            if(quantity < 1)
                            {
                                lblQuantityError.Visible = true;
                                lblQuantityError.Text = "Please enter a valid book quantity";
                            }

                            else
                            {
                                lblQuantityError.Visible = false;
                                queryStatus = book.add(first, second, today.ToString("yyyy-MM-d"), quantity);
                                dashboardUI.showBooksUI();
                                Dashboard.title = txtFirst.Text.Trim();
                                dashboard.showQueryMessage(queryStatus, "adde");
                                dashboard.updateStatistics(this.context);

                                this.Close();
                            }
                        }

                        else
                        {
                            lblQuantityError.Visible = true;
                            lblQuantityError.Text = "Please enter a valid book quantity";
                        }
                    }
                }
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
            string username = txtUsername.Text.Trim();

            if ((first == "" && second == "" && username == "" ) || (first == "" || second == "" || username == ""))
            {
                valid = false;
                lblQuantityError.Visible = false;
            }

            else if (username.Length < 6 && context == "borrowers")
            {
                valid = false;
                lblQuantityError.Visible = true;
                lblQuantityError.Text = "Usernames should be greater than 6 characters";
            }

            else
            {
                valid = true;
                lblQuantityError.Visible = false;
            }

            return valid;
        }
    }
}
