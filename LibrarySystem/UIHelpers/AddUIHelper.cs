using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace LibrarySystem.Class
{
    class AddUIHelper : IErrorController

    {
        private Add addUI;

        public AddUIHelper(Add addUI)
        {
            this.addUI = addUI;
        }

        public void loadAddBorrowerUI()
        {
            // Lab path
            // Z:/QQ412/Fernandez, Mike Andrew/library-system/Assets
            //Image borrower = Image.FromFile(@"Z:/QQ412/Fernandez, Mike Andrew/library-system/Assets/Component Icons/user_avatar.ico");
            //addUI.image.Image = borrower;

            addUI.lblTitle.Text = "Add borrower";
            addUI.lblDescription.Text = "Please provide the necessary borrower details below";

            addUI.lblFirst.Text = "Firstname";
            addUI.lblSecond.Text = "Lastname";

            addUI.btnSave.Text = "Add borrower";
        }

        public void loadAddBookUI()
        {
            //Image book = Image.FromFile(@"Z:/QQ412/Fernandez, Mike Andrew/library-system/Assets/book_open.ico");
            //addUI.image.Image = book;

            addUI.lblTitle.Text = "Add book";
            addUI.lblDescription.Text = "Please provide the necessary book details below";

            addUI.lblFirst.Text = "Title";
            addUI.lblSecond.Text = "Author";
            addUI.lblUsername.Text = "Book quantity";

            addUI.btnSave.Text = "Add book";
        }

        public void showErrorMessage()
        {
            addUI.lblErrorTitle.Visible = true;
            addUI.lblErrorTitle.Text = "All fields are required";
        }

        public void hideErrorMessage()
        {
            addUI.lblErrorTitle.Visible = false;
        }

        public void showBorrowerExistMessage()
        {
            addUI.lblErrorTitle.Text = "This username already exist";
        }

        public void showBookExistMessage()
        {
            addUI.lblErrorTitle.Text = "This book already exist";
        }
    }
}
