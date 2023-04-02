using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class BorrowerUIHelper
    {
        Borrower borrower;

        public BorrowerUIHelper(Borrower borrower)
        {
            this.borrower = borrower;
        }

        public void loadHomeUI()
        {
            borrower.flpTop.Visible = true;
            borrower.panelBorrow.Visible = true;
            borrower.flpDataGrid.Visible = true;
            borrower.flpEdit.Visible = false;
        }

        public void loadProfileUI()
        {
            borrower.flpTop.Visible = false;
            borrower.panelBorrow.Visible = false;
            borrower.flpDataGrid.Visible = false;
            borrower.flpEdit.Visible = true;

            borrower.txtFirstname.Text = $"{Login.firstName}";
            borrower.txtLastname.Text = $"{Login.lastName}";
            borrower.txtUsername.Text = $"{Login.username}";
        }

        public void showUsernameExistsMessage()
        {
            borrower.lblProfileError.Visible = true;
            borrower.lblProfileError.Text = "This username already exists!";
        }

        public void showInvalidUsernameMessage()
        {
            borrower.lblProfileError.Visible = true;
            borrower.lblProfileError.Text = "Usernames should be greater than 6 characters!";
        }

        public void showInvalidNameMessage()
        {
            borrower.lblProfileError.Visible = true;
            borrower.lblProfileError.Text = "Please provide a name or username";

        }

        
        public void showSavedStatus()
        {
            borrower.lblProfileError.Visible = true;
            borrower.lblProfileError.Text = "Changes has been saved";
            borrower.lblProfileError.ForeColor = Color.ForestGreen;

        }

        public void showPasswordSavedStatus()
        {
            borrower.lblProfileError.Visible = true;
            borrower.lblProfileError.Text = "Password has been saved";
            borrower.lblProfileError.ForeColor = Color.ForestGreen;

        }

        public void hideErrorMessage()
        {
            borrower.lblProfileError.Visible = false;
            borrower.lblPasswordError.Visible = false;
        }
    }
}
