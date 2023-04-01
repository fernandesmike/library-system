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
using LibrarySystem.Repository;
using LibrarySystem.Enums;

namespace LibrarySystem
{
    public partial class Details : Form
    {
        // Data Repositories
        private readonly BookRepository book;
        private readonly BorrowerRepository borrower;

        private readonly DetailsUIHelper detailsUI;

        private string context;
        private string connection;

        private int _newQuantity = 0;

        public Details(string context)
        {
            InitializeComponent();
            //TODO: Change data source
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            book = new BookRepository(connection);
            borrower = new BorrowerRepository(connection);

            detailsUI = new DetailsUIHelper(this);

            this.context = context;
        }

        private async void BorrowerInfo_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                this.Invoke((MethodInvoker) delegate
               {
                   if (context == "borrowers")
                   {
                       detailsUI.loadBorrowerData();
                   }
                   else if (context == "books")
                   {
                       detailsUI.loadBookData();
                   }
               });
            });
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
                if (Dashboard.status == "1")
                {
                    borrower.updateStatus(Dashboard.id, (int) Status.INACTIVE);
                    detailsUI.updateStatus("0", context);
                    Dashboard.status = "0";
                }

                // Enable account
                else if (Dashboard.status == "0")
                {
                    borrower.updateStatus(Dashboard.id, (int) Status.ACTIVE);
                    detailsUI.updateStatus("1", context);
                    Dashboard.status = "1";
                }
            }

            else if (context == "books")
            {
                // Disable account
                if (Dashboard.status == "0")
                {
                    book.updateStatus(Dashboard.id, (int) Status.ACTIVE);
                    detailsUI.updateStatus("1", context);
                    Dashboard.status = "1";
                }

                // Enable account
                else if (Dashboard.status == "1")
                {
                    book.updateStatus(Dashboard.id, (int) Status.INACTIVE);
                    detailsUI.updateStatus("0", context);
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
                queryStatus = borrower.delete(Dashboard.id);

                returnToDashboard.Show();
                returnToDashboard.showQueryMessage(queryStatus, "delete");
            }

            else if ( context == "books")
            {
                queryStatus = book.delete(Dashboard.id);

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
            detailsUI.showEdit(context);
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            // Get the original data values
            string first = Dashboard.id;
            string second = Dashboard.firstName;
            string third = Dashboard.lastName;
            string username = Dashboard.username;
            string quantity = Dashboard.quantities;

            // Get the new data values
            string newSecond = txtSecond.Text.Trim();
            string newThird = txtThird.Text.Trim();
            string newUsernameOrQuantity = txtUsername.Text.Trim();

            int status;

           
        }

        private bool validateFields()
        {
            bool valid = false;

            if(context == "borrowers")
            {
                if(string.IsNullOrWhiteSpace(txtSecond.Text) || string.IsNullOrWhiteSpace(txtThird.Text))
                {
                    lblEditError.Visible = true;
                    lblEditError.Text = "Cannot accept an empty name or username";
                    valid = false;
                }

                else if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text.Length < 6)
                {
                    lblEditError.Visible = true;
                    lblEditError.Text = "Usernames should be greater than 6 characters";
                    valid = false;
                }

                else
                {
                    valid = true;
                }
            }

            else if (context == "books")
            {
                if (string.IsNullOrWhiteSpace(txtSecond.Text) || string.IsNullOrWhiteSpace(txtThird.Text))
                {
                    lblEditError.Visible = true;
                    lblEditError.Text = "Please provide both book title and author";
                    valid = false;
                }

                else if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    if (int.TryParse(txtUsername.Text, out _newQuantity))
                    {
                        lblEditError.Visible = true;
                        lblEditError.Text = "Please enter a valid book quantity";
                        valid = false;

                        if (_newQuantity < 1)
                        {
                            lblEditError.Visible = true;
                            lblEditError.Text = "Please enter a valid book quantity";
                            valid = false;
                        }

                        else
                        {
                            lblEditError.Visible = false;
                            valid = true;
                        }
                    }
                    
                    else
                    {
                        lblEditError.Visible = false;
                        valid = true;
                    }
                }
            }

            return valid;
        }

        private void LblCancelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            detailsUI.hideEdit(context);
            detailsUI.hideErrorMessage();
        }

        private void TmHideMessage_Tick(object sender, EventArgs e)
        {
            lblUpdateMessage.Visible = false;
            lblUpdateMessage.Height = 1;
            tmHideMessage.Enabled = false;
        }
    }
}
