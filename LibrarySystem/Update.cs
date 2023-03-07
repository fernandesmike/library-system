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
    public partial class Update : Form
    {
        string connectionString;

        public Update()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }

        private void Update_Load(object sender, EventArgs e)
        {
            lblBookID.Text = "Book ID: " + Dashboard.id;
            lblBookTitle.Text = Dashboard.title;
            lblAuthor.Text = "by " + Dashboard.author;
        }

        private void BtnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // If title and author was not provided
            if (txtAuthor.Text.Trim() == "" && txtTitle.Text.Trim() == "")
            {
                lblErrorAuthor.Visible = true;
                lblErrorAuthor.Text = "Please provide a book author";
                lblErrorTitle.Visible = true;
                lblErrorTitle.Text = "Please provide a book title";
            }
            // If author is empty
            else if (txtAuthor.Text.Trim() == "")
            {
                lblErrorAuthor.Visible = true;
                lblErrorTitle.Visible = false;
                lblErrorAuthor.Text = "Please provide a book author";
            }
            // If title is empty
            else if (txtTitle.Text.Trim() == "")
            {
                lblErrorAuthor.Visible = false;
                lblErrorTitle.Visible = true;
                lblErrorTitle.Text = "Please provide a book title";
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string command = "UPDATE tbl_books SET title = @title, author = @author WHERE book_id = @id";
                        con.Open();

                        SqlCommand cmd = new SqlCommand(command, con);
                        cmd.Parameters.AddWithValue("@id", Dashboard.id);
                        cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim());
                        cmd.ExecuteNonQuery();

                        lblErrorAuthor.Visible = false;
                        lblErrorTitle.Visible = false;

                        txtTitle.Clear();
                        txtAuthor.Clear();

                        MessageBox.Show("Book has been successfully updated!");
                        this.Close();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err + " Cannot perform operation!");
                }
            }
        }
    }
}
