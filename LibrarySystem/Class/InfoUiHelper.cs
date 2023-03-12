using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LibrarySystem
{
    class InfoUIHelper
    {
        private DataDetails infoUI;
        private DataHelper data;
        private string connectionString;

        DateTime currentDate;

        public InfoUIHelper(DataDetails infoUI)
        {
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            this.infoUI = infoUI;
            data = new DataHelper(connectionString);
            currentDate = DateTime.Today;
        }

        /// <summary>
        /// Starts the form with the specified data from the data grid inside Dashboard form
        /// </summary>
        public void loadBorrowerData()
        {
            Image borrower = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/Component Icons/user_avatar.ico");
            infoUI.imgAvatar.Image = borrower;

            infoUI.lblID.Text = "ID: " + Dashboard.id;
            infoUI.lblUser.Text = Dashboard.fullName;
            infoUI.lblType.Text = "Borrower";
            infoUI.lblTitle.Text = Dashboard.firstName + "'s statistics";
            infoUI.lblDate.Text = "As of " + currentDate.ToString("dd MMMM, yyy");

            infoUI.lblWarning.Text = "WARNING:\nDeleting accounts cannot be undone!";
            infoUI.btnEdit.Text = "Edit account";
            infoUI.btnDelete.Text = "Delete account";

            updateStatus(Dashboard.status, "borrowers");
        }

        public void loadBookData()
        {
            Image book = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/book_open.ico");
            infoUI.imgAvatar.Image = book;

            infoUI.lblID.Text = "ID: " + Dashboard.id;
            infoUI.lblUser.Text = Dashboard.title;
            infoUI.lblType.Text = "by " + Dashboard.author;
            infoUI.lblTitle.Text = Dashboard.title + "'s statistics";
            infoUI.lblDate.Text = "As of " + currentDate.ToString("dd MMMM, yyy");

            infoUI.lblWarning.Text = "WARNING:\nDeleting books cannot be undone!";
            infoUI.btnEdit.Text = "Edit book";
            infoUI.btnDelete.Text = "Delete book";

            updateStatus(Dashboard.status, "books");
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
                infoUI.iconStatus.Image = disabled;
                infoUI.lblStatus.ForeColor = Color.ForestGreen;
                infoUI.btnStatus.Text = "Disable account";
                infoUI.lblStatus.Text = "Account active";

            }

            else if (status.ToUpper() == "INACTIVE")
            {
                infoUI.iconStatus.Image = enabled;
                infoUI.lblStatus.ForeColor = Color.Red;
                infoUI.btnStatus.Text = "Enable account";
                infoUI.lblStatus.Text = "Account disabled";
            }
            else if (status == "1")
            {
                infoUI.iconStatus.Image = disabled;
                infoUI.lblStatus.ForeColor = Color.ForestGreen;
                infoUI.btnStatus.Text = "Mark Unavailable";
                infoUI.lblStatus.Text = "Available";
            }

            else if (status == "0")
            {
                infoUI.iconStatus.Image = enabled;
                infoUI.lblStatus.ForeColor = Color.Red;
                infoUI.btnStatus.Text = "Mark available";
                infoUI.lblStatus.Text = "Unavailable";
            }
        }
    }
}
