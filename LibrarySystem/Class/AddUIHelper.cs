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
    class AddUIHelper
    {
        private Add addUI;

        public AddUIHelper(Add addUI)
        {
            this.addUI = addUI;
        }

        public void loadAddBorrowerUI()
        {
            Image borrower = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/Component Icons/user_avatar.ico");
            addUI.image.Image = borrower;

            addUI.lblTitle.Text = "Add borrower";
            addUI.lblDescription.Text = "Please provide the necessary borrower details below";

            addUI.lblFirst.Text = "Firstname";
            addUI.lblSecond.Text = "Lastname";

            addUI.btnSave.Text = "Add borrower";
        }

        public void loadAddBookUI()
        {
            Image book = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/book_open.ico");
            addUI.image.Image = book;

            addUI.lblTitle.Text = "Add book";
            addUI.lblDescription.Text = "Please provide the necessary book details below";

            addUI.lblFirst.Text = "Title";
            addUI.lblSecond.Text = "Author (comma separated for multiple authors)";

            addUI.btnSave.Text = "Add book";
        }
    }
}
