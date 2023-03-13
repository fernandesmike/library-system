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

            addUI = new AddUIHelper(this);
            this.dashboard = dashboard;

            data = new DataHelper(connectionString);
            dashboardUI = new DashboardUIHelper(this.dashboard);
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
            if (context == "borrowers")
            {
                data.addBorrower(txtFirst.Text.Trim(), txtSecond.Text.Trim());
                dashboardUI.showBorrowersUI();
            }

            else if (context == "books")
            {
                data.addBook(txtFirst.Text.Trim(), txtSecond.Text.Trim());
                dashboardUI.showBooksUI();
            }

            this.Close();
        }
    }
}
