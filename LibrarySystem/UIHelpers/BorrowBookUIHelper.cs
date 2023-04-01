using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{

    class BorrowBookUIHelper
    {
        private BorrowBook borrowUI;

        public BorrowBookUIHelper(BorrowBook borrow)
        {
            borrowUI = borrow;
        }

        public void resetUI()
        {
            borrowUI.lblID.Text = "-";
            borrowUI.lblBookTitle.Text = "Please select a book";
            borrowUI.lblBookAuthor.Text = "-";
            borrowUI.lblBookAuthor.Visible = true;
            borrowUI.txtQuantities.Enabled = false;

            borrowUI.lblMessage.Text = "Please select a book to borrow";

            borrowUI.btnBorrow.Enabled = false;
        }

        public void displayBookToBorrow(string id, string title, string author, string copies)
        {
            borrowUI.lblID.Text = $"Book ID: {id}";
            borrowUI.lblBookTitle.Text = $"{title}";
            borrowUI.lblBookAuthor.Text = $"by {author}";
            borrowUI.lblAvailableCopies.Text = $"{copies} copies are available";
            borrowUI.lblBookAuthor.Visible = true;
            borrowUI.txtQuantities.Enabled = true;

            borrowUI.lblMessage.Text = "You are about to borrow the book";

            borrowUI.btnBorrow.Enabled = true;
        }

        public void showMessage(string title)
        {
            borrowUI.lblUpdateMessage.Text = $"Successfully borrowed {title}";
            borrowUI.lblUpdateMessage.Height = 31;
            borrowUI.lblUpdateMessage.Visible = true;
            borrowUI.tmHideMessage.Enabled = true;
        }

    }
}
