using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem
{
    public partial class BorrowerInfo : Form
    {

        private InfoUIHelper infoUI;
        private DataHelper data;
        private string connectionString;


        public BorrowerInfo()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            data = new DataHelper(connectionString);
            infoUI = new InfoUIHelper(this);
        }

        private void BorrowerInfo_Load(object sender, EventArgs e)
        {
            infoUI.loadData();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Dashboard returnToDashboard = new Dashboard();
            this.Close();
            returnToDashboard.Show();
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            // Disable account
            if(Dashboard.status.ToLower() == "active")
            {
                data.changeBorrowerStatus(Dashboard.id, "inactive");
                infoUI.updateStatus("inactive");
                Dashboard.status = "inactive";
            }

            // Enable account
            else if (Dashboard.status.ToLower() == "inactive")
            {
                data.changeBorrowerStatus(Dashboard.id, "active");
                infoUI.updateStatus("active");
                Dashboard.status = "active";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // TODO:
            // Update the message
            // The message should warn if the user has pending books that is yet to be returned
            flpConfirm.Visible = true;
        }

        private void BtnConfirm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            data.deleteBorrower(Dashboard.id);

            Dashboard returnToDashboard = new Dashboard();
            this.Close();
            returnToDashboard.Show();
        }

        private void BtnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flpConfirm.Visible = false;
        }

        // TODO: 
        // fetch user statistics data
        // fetch user transactions
        // edit account
    }
}
