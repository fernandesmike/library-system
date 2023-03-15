using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using LibrarySystem.Class;

namespace LibrarySystem
{
    class DetailsUIHelper : IErrorController
    {
        private Details detailsUI;
        private DataHelper data;
        private string connectionString;

        DateTime currentDate;

        public DetailsUIHelper(Details detailsUI)
        {
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            this.detailsUI = detailsUI;
            data = new DataHelper(connectionString);
            currentDate = DateTime.Today;
        }

        /// <summary>
        /// Starts the form with the specified data from the data grid inside Dashboard form
        /// </summary>
        public void loadBorrowerData()
        {
            Image borrower = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/Component Icons/user_avatar.ico");
            detailsUI.imgAvatar.Image = borrower;

            detailsUI.lblID.Text = "ID: " + Dashboard.id;
            detailsUI.lblUser.Text = Dashboard.fullName;
            detailsUI.lblType.Text = "Borrower";
            detailsUI.lblTitle.Text = Dashboard.firstName + "'s statistics";
            detailsUI.lblDate.Text = "As of " + currentDate.ToString("dd MMMM, yyy");

            detailsUI.lblWarning.Text = "WARNING:\nDeleting accounts cannot be undone!";
            detailsUI.btnEdit.Text = "Edit account";
            detailsUI.btnDelete.Text = "Delete account";

            updateStatus(Dashboard.status, "borrowers");
        }

        public void loadBookData()
        {
            Image book = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/book_open.ico");
            detailsUI.imgAvatar.Image = book;

            detailsUI.lblID.Text = "ID: " + Dashboard.id;
            detailsUI.lblUser.Text = Dashboard.title;
            detailsUI.lblType.Text = "by " + Dashboard.author;
            detailsUI.lblTitle.Text = Dashboard.title + "'s statistics";
            detailsUI.lblDate.Text = "As of " + currentDate.ToString("dd MMMM, yyy");

            detailsUI.lblWarning.Text = "WARNING:\nDeleting books cannot be undone!";
            detailsUI.btnEdit.Text = "Edit book";
            detailsUI.btnDelete.Text = "Delete book";

            updateStatus(Dashboard.status, "books");
        }

        public void showEdit(string context)
        {
            detailsUI.flpEdit.Visible = true;

            detailsUI.flpStatistics.Visible = false;
            detailsUI.flpDataGrid.Visible = false;

            detailsUI.btnStatus.Enabled = false;
            detailsUI.btnDelete.Enabled = false;


            if (context == "borrowers")
            {
                detailsUI.lblTitle.Text = "Edit " + Dashboard.firstName  +"'s account";
                detailsUI.lblDate.Text = "Please provide the desired information\nbelow";

                detailsUI.lblFirst.Text = "ID Number";
                detailsUI.lblSecond.Text = "Firstname";
                detailsUI.lblThird.Text = "Lastname";

                detailsUI.txtFirst.Text = Dashboard.id.Trim();
                detailsUI.txtSecond.Text = Dashboard.firstName.Trim();
                detailsUI.txtThird.Text = Dashboard.lastName.Trim();
            }

            else if (context == "books")
            {
                detailsUI.lblTitle.Text = "Edit book ";
                detailsUI.lblDate.Text = "Please provide the desired\ninformation below";

                detailsUI.lblFirst.Text = "Book ID";
                detailsUI.lblSecond.Text = "Title";
                detailsUI.lblThird.Text = "Author";

                detailsUI.txtFirst.Text = Dashboard.id.Trim();
                detailsUI.txtSecond.Text = Dashboard.title.Trim();
                detailsUI.txtThird.Text = Dashboard.author.Trim();
            }
        }

        public void hideEdit(string context)
        {
            detailsUI.flpEdit.Visible = false;

            detailsUI.flpStatistics.Visible = true;
            detailsUI.flpDataGrid.Visible = true;

            detailsUI.btnStatus.Enabled = true;
            detailsUI.btnDelete.Enabled = true;

            if (context == "borrowers")
            {
                loadBorrowerData();
            }

            else if (context == "books")
            {
                loadBookData();
            }

        }

        public void updateStatus(string status, string context)
        {
            // TODO:
            // Update this to support UI changes depending on context

            // The full path of the ico
            Image enabled = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/Component Icons/onswitch.ico");
            Image disabled = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/Component Icons/off.ico");

            if (status.ToUpper() == "ACTIVE")
            {
                detailsUI.iconStatus.Image = disabled;
                detailsUI.lblStatus.ForeColor = Color.ForestGreen;
                detailsUI.btnStatus.Text = "Disable account";
                detailsUI.lblStatus.Text = "Account active";

            }

            else if (status.ToUpper() == "INACTIVE")
            {
                detailsUI.iconStatus.Image = enabled;
                detailsUI.lblStatus.ForeColor = Color.Red;
                detailsUI.btnStatus.Text = "Enable account";
                detailsUI.lblStatus.Text = "Account disabled";
            }

            else if (status == "1")
            {
                detailsUI.iconStatus.Image = disabled;
                detailsUI.lblStatus.ForeColor = Color.ForestGreen;
                detailsUI.btnStatus.Text = "Mark Unavailable";
                detailsUI.lblStatus.Text = "Available";
            }

            else if (status == "0")
            {
                detailsUI.iconStatus.Image = enabled;
                detailsUI.lblStatus.ForeColor = Color.Red;
                detailsUI.btnStatus.Text = "Mark available";
                detailsUI.lblStatus.Text = "Unavailable";
            }
        }

        // NOTE
        // Make these two methods an interface
        // Same methods also exist inside AddUIHelper class

        public void showErrorMessage()
        {
            detailsUI.lblEditError.Visible = true;
        }

        public void hideErrorMessage()
        {
            detailsUI.lblEditError.Visible = false;
        }

        public void showBorrowerExistMessage()
        {
            detailsUI.lblEditError.Text = "The desired changes has conflict with another\nborrower";
        }

        public void showBookExistMessage()
        {
            detailsUI.lblEditError.Text = "The desired changes has conflict with another\nbook";
        }

        public void showUpdateMessage(int status)
        {
            detailsUI.lblUpdateMessage.Visible = true;
            detailsUI.tmHideMessage.Enabled = true;

            if (status > 0)
            {
                detailsUI.lblUpdateMessage.Height = 31;
                detailsUI.lblUpdateMessage.BackColor = Color.ForestGreen;
                detailsUI.lblUpdateMessage.ForeColor = Color.White;
                detailsUI.lblUpdateMessage.Text = "Changes has been saved";
            }

            else
            {
                detailsUI.lblUpdateMessage.Height = 31;
                detailsUI.lblUpdateMessage.BackColor = Color.Red;
                detailsUI.lblUpdateMessage.ForeColor = Color.White;
                detailsUI.lblUpdateMessage.Text = "No changes have been made";
            }
        }
    }
}
