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

        public Delete()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        private void BtnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // Get the currently selected row
            lblBookID.Text = "Book ID: " + Dashboard.id;
            lblBookTitle.Text = Dashboard.title;
            lblAuthor.Text = "by " + Dashboard.author;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string command = "DELETE FROM tbl_books WHERE book_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@id", Dashboard.id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book has been successfully deleted.");
                    this.Close();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err + "Cannot remove the book.");
            }
        }
    }
}
