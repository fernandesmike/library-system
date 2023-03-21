using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibrarySystem
{
    class DashboardUIHelper
    {
        private Dashboard dashboard;
        DateTime currentDate;

        public DashboardUIHelper(Dashboard dashboard)
        {
            this.dashboard = dashboard;
            currentDate = DateTime.Today;
        }

        // Borrower helper methods
        public void showBorrowersUI()
        {
            // Change the current screen context
            dashboard.context = "borrowers";

            // Title
            dashboard.lblContext.Text = "Borrowers";
            dashboard.lblParagraph.Text = "Manage borrower accounts and \nview statistics";
            dashboard.lblSearch.Text = "Search borrowers";

            // Statistics
            dashboard.lblTotalBorrowers.Text = "Total borrowers";
            dashboard.lblActive.Text = "Active borrowers";
            dashboard.lblInactive.Text = "Inactive borrowers";

            // Grid header
            dashboard.lblGridTitle.Text = "All borrowers";
            dashboard.btnAdd.Text = " + Add borrowers";
            dashboard.btnAdd.Enabled = true;

            dashboard.rbActive.Text = "Active";
            dashboard.rbInactive.Text = "Inactive";

            dashboard.radioContainer.Visible = true;
            dashboard.flpBorrowersUI.Visible = true;
            dashboard.flpSearch.Visible = true;
            dashboard.flpDataGrid.Visible = true;
            dashboard.flpSearch.Visible = true;
            dashboard.datePicker.Visible = false;

            dashboard.rbAll.Select();

            refreshDataGrid();
        }

        // Books helper methods
        public void showBooksUI()
        {
            dashboard.context = "books";

            // Change headers 
            dashboard.lblContext.Text = "Books";
            dashboard.lblParagraph.Text = "View and manage system books \nhere ";
            dashboard.lblSearch.Text = "Search books";

            dashboard.lblTotalBorrowers.Text = "Total books";
            dashboard.lblActive.Text = "Available books";
            dashboard.lblInactive.Text = "Borrowed books";

            dashboard.lblGridTitle.Text = "All books";
            dashboard.btnAdd.Text = " + Add books";
            dashboard.btnAdd.Enabled = true;

            dashboard.rbActive.Text = "Available";
            dashboard.rbInactive.Text = "Borrowed";

            dashboard.radioContainer.Visible = true;
            dashboard.flpBorrowersUI.Visible = true;
            dashboard.flpDataGrid.Visible = true;
            dashboard.flpSearch.Visible = true;
            dashboard.datePicker.Visible = false;

            dashboard.rbAll.Select();

            refreshDataGrid();
        }

        // Reports helper methods
        public void showReportsUI()
        {
            dashboard.context = "reports";

            dashboard.lblContext.Text = "Reports";
            dashboard.lblParagraph.Text = "View and generate system reports";
            dashboard.lblSearch.Text = "Search reports";

            dashboard.lblTotalBorrowers.Text = "Total borrowers";
            dashboard.lblActive.Text = "Total books";
            dashboard.lblInactive.Text = "Total transactions";
            dashboard.lblGridTitle.Text = "All transactions";

            dashboard.btnAdd.Text = " ";
            dashboard.btnAdd.Enabled = false;

            dashboard.radioContainer.Visible = false;
            dashboard.flpSearch.Visible = false;
            dashboard.datePicker.Visible = true;
            
            // Display simple, graphical reports
            // Include date filters
            // Display all the necessary data

            refreshDataGrid();
        }

        public void borrowerQueryMessage(string action, int status, string name)
        {
            dashboard.lblUpdateMessage.Visible = true;
            dashboard.tmHideMessage.Enabled = true;

            if (status > 0)
            {
                successStyling();
                dashboard.lblUpdateMessage.Text = $"Successfully {action}d borrower {name}";
            }

            else
            {
                failedStyling();
                dashboard.lblUpdateMessage.Text = $"Cannot {action} borrower {name}";
            }

        }

        public void bookQueryMessage(string action, int status, string title)
        {
            dashboard.lblUpdateMessage.Visible = true;
            dashboard.tmHideMessage.Enabled = true;

            if (status > 0)
            {
                successStyling();
                dashboard.lblUpdateMessage.Text = $"Successfully {action}d book {title}";
            }

            else
            {
                failedStyling();
                dashboard.lblUpdateMessage.Text = $"Cannot {action} book {title}";
            }

        }

        public void successStyling()
        {
            dashboard.lblUpdateMessage.Height = 31;
            dashboard.lblUpdateMessage.BackColor = Color.ForestGreen;
            dashboard.lblUpdateMessage.ForeColor = Color.White;
        }

        public void failedStyling()
        {
            dashboard.lblUpdateMessage.Height = 31;
            dashboard.lblUpdateMessage.BackColor = Color.Red;
            dashboard.lblUpdateMessage.ForeColor = Color.White;
        }

        /// <summary>
        /// Refresh the graphic rendering of the data grid. Prevents the texts in the data grid from overlapping
        /// </summary>
        private void refreshDataGrid()
        {
            dashboard.dataGrid.Visible = false;
            dashboard.dataGrid.Visible = true;
        }

    }
}
