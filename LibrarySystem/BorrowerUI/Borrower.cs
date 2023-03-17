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
        private string connectionString;

        // Helper classes
        BorrowerUIHelper borrowerUI;
        DataHelper data;

        public Borrower()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            borrowerUI = new BorrowerUIHelper(this);
            data = new DataHelper(connectionString, dataGrid);
        }

        private void Borrower_Load(object sender, EventArgs e)
        {
            lblUser.Text = Login.currentUser;
            borrowerUI.loadHomeUI();

            data.loadAvailableBooks();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            this.Hide();
            borrow.ShowDialog();
        }
    }
}
