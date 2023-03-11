using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem
{
    public partial class Delete : Form
    {
        private string connectionString;
        private string context;
        private DataHelper data;

        public Delete(String context)
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            this.context = context;
            data = new DataHelper(connectionString);
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            Image user = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/Component Icons/user_avatar.ico");
            Image book = Image.FromFile(@"C:/Users/ferna/OneDrive/Desktop/Application Development/DBSYS - Prelim/Assets/book_open.ico");

            if (context.ToLower() == "borrower")
            {
                picture.Image = user;
                header.Text = "Are you sure you want to delete\nthis borrower?";

                lblID.Text = "Book ID: " + Dashboard.id;
                lblTitle.Text = Dashboard.fullName;
                lblAuthor.Text = "Borrower";
            }
            else if (context.ToLower() == "book")
            {
                picture.Image = book;
                header.Text = "Are you sure you want to delete\nthis book?";

                lblID.Text = "Book ID: " + Dashboard.id;
                lblTitle.Text = Dashboard.title;
                lblAuthor.Text = "by " + Dashboard.author;
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            data.deleteBorrower(Dashboard.id);
            this.Close();
        }

        private void BtnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
