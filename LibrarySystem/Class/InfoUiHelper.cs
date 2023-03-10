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
        private BorrowerInfo infoUI;

        public InfoUIHelper(BorrowerInfo infoUI)
        {
            this.infoUI = infoUI;
        }

        /// <summary>
        /// Starts the form with the specified data from the data grid inside Dashboard form
        /// </summary>
        public void loadData()
        {
            DateTime currentDate = DateTime.Today;

            infoUI.lblID.Text = "ID: " + Dashboard.id;
            infoUI.lblUser.Text = Dashboard.fullName;
            infoUI.lblTitle.Text = Dashboard.firstName + "'s statistics";
            infoUI.lblDate.Text = "As of " + currentDate.ToString("dd MMMM, yyy");

            updateStatus(Dashboard.status);
        }

        public void updateStatus(String status)
        {
            // The full path of the ico
            Image enabled = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/Component Icons/onswitch.ico");
            Image disabled = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/Component Icons/off.ico");

            if (status.ToUpper() == "ACTIVE")
            {
                infoUI.iconStatus.Image = disabled;
                infoUI.btnStatus.Text = "Disable account";
                infoUI.lblStatus.Text = "Account active";
                infoUI.lblStatus.ForeColor = Color.ForestGreen;
            }
            else if (status.ToUpper() == "INACTIVE")
            {
                infoUI.iconStatus.Image = enabled;
                infoUI.btnStatus.Text = "Enable account";
                infoUI.lblStatus.Text = "Account disabled";
                infoUI.lblStatus.ForeColor = Color.Red;
            }
        }
    }
}
