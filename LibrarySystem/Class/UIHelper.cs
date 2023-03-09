﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class UIHelper
    {
        private Dashboard dashboard;

        public UIHelper(Dashboard dashboard)
        {
            this.dashboard = dashboard;
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

            dashboard.flpBorrowersUI.Visible = true;

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
            dashboard.lblActive.Text = "Borrowed books";
            dashboard.lblInactive.Text = "Returned books";

            dashboard.lblGridTitle.Text = "All books";
            dashboard.btnAdd.Text = " + Add books";

            dashboard.rbActive.Text = "Borrowed";
            dashboard.rbInactive.Text = "Returned";

            dashboard.flpBorrowersUI.Visible = true;

            // Add books

            refreshDataGrid();
        }

        // Reports helper methods
        public void showReportsUI()
        {
            dashboard.context = "reports";

            dashboard.lblContext.Text = "Reports";
            dashboard.lblParagraph.Text = "View and generate system reports \nand inventories";
            dashboard.lblSearch.Text = "Search reports";

            dashboard.flpBorrowersUI.Visible = false;

            // Display simple, graphical reports
            // Include date filters
            // Display all the necessary data

            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            dashboard.dataGrid.Visible = false;
            dashboard.dataGrid.Visible = true;
        }
    }
}