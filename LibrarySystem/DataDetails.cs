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
    public partial class DataDetails : Form
    {

        private InfoUIHelper infoUI;
        private DataHelper data;

        private string context;
        private string connectionString;

        public DataDetails(string context)
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            data = new DataHelper(connectionString);

            infoUI = new InfoUIHelper(this);

            this.context = context;
        }

        private void BorrowerInfo_Load(object sender, EventArgs e)
        {
            if(context == "borrowers")
            {
                infoUI.loadBorrowerData();
            }
            else if(context == "books")
            {
                infoUI.loadBookData();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Dashboard returnToDashboard = new Dashboard();
            this.Close();

            if (context == "borrowers")
            {
                returnToDashboard.Show();
            }

            else if (context == "books")
            {
                returnToDashboard = new Dashboard(this.context);
                returnToDashboard.Show();
            }
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {

            if (context == "borrowers")
            {
                // Disable account
                if (Dashboard.status.ToLower() == "active")
                {
                    data.changeBorrowerStatus(Dashboard.id, "inactive");
                    infoUI.updateStatus("inactive", context);
                    Dashboard.status = "inactive";
                }

                // Enable account
                else if (Dashboard.status.ToLower() == "inactive")
                {
                    data.changeBorrowerStatus(Dashboard.id, "active");
                    infoUI.updateStatus("active", context);
                    Dashboard.status = "active";
                }
            }
            else if (context == "books")
            {
                // Disable account
                if (Dashboard.status == "0")
                {
                    data.updateBookStatus(Dashboard.id, "1");
                    infoUI.updateStatus("1", context);
                    Dashboard.status = "1";
                }

                // Enable account
                else if (Dashboard.status == "1")
                {
                    data.updateBookStatus(Dashboard.id, "0");
                    infoUI.updateStatus("0", context);
                    Dashboard.status = "0";
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // TODO:
            // Update the message
            // The message should warn if the user has pending books that is yet to be returned
            lblMessage.Text = Dashboard.firstName + " has (count) pending books that is yet to be returned";
            flpConfirm.Visible = true;
        }

        private void BtnConfirm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard returnToDashboard = new Dashboard();
            this.Close();

            int queryStatus;

            if (context == "borrowers")
            {
                queryStatus = data.deleteBorrower(Dashboard.id);    

                returnToDashboard.Show();
                returnToDashboard.showQueryMessage(queryStatus, "delete");
            }

            else if ( context == "books")
            {
                queryStatus = data.deleteBook(Dashboard.id);

                returnToDashboard = new Dashboard(this.context);
                returnToDashboard.Show();
                returnToDashboard.showQueryMessage(queryStatus, "delete");
            }
        }

        private void BtnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flpConfirm.Visible = false;
        }

        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RbBorrowed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbReturned_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            infoUI.showEdit(context);
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            // TODO:
            // Using ExecuteNonQuery(), check if a data is successfully updated or not
            // If a data is updated, show a control below datagrid and after several seconds make it invisible
            // If not, display error on that control
            Dashboard returnToDashboard = new Dashboard();
            this.Close();

            if (context == "borrowers")
            {
                returnToDashboard.Show();
            }

            else if (context == "books")
            {
                returnToDashboard = new Dashboard(this.context);
                returnToDashboard.Show();
            }
        }

        private void LblCancelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infoUI.hideEdit(context);
        }  

        // TODO: 
        // fetch user statistics data
        // fetch user transactions
    }
}
