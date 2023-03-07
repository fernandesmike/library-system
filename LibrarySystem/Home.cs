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
    public partial class Dashboard : Form
    {
        private string connectionString;
        private DataHelper data;

        // Static variables used to extract data to other forms
        public static string id;
        public static string title;
        public static string author;

        public Dashboard()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            data = new DataHelper(connectionString, dataGrid);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Greet the user
            lblUser.Text = Login.currentUser;
            
            // Populate the data grid everytime the form loads
            data.loadBooks();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            data.searchBooks(txtSearch.Text.Trim());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
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
            // If all data are provided
            else
            {
                // Remove all error messages
                lblErrorAuthor.Visible = false;
                lblErrorTitle.Visible = false;

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string command = "INSERT INTO tbl_books(book_id, title, author) VALUES (NEXT VALUE FOR sequence_id, @title, @author)";
                        con.Open();

                        SqlCommand cmd = new SqlCommand(command, con);
                        cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim());
                        cmd.ExecuteNonQuery();

                        // Close the connection before calling loadData() method
                        // Because loadData() method will always open the connection
                        con.Close();
                        data.loadAllBooks();

                        // Clean the UI when book is added
                        txtTitle.Clear();
                        txtAuthor.Clear();
                        txtSearch.Clear();

                        dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGrid.ColumnHeadersDefaultCellStyle.BackColor;

                        MessageBox.Show("Book " + title + " has been successfully added!");
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err + " There was an error inserting the book!");
                }
            }
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the currently selected row
            DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

            // DEBUGGER
            txtTitle.Text = "" + e.RowIndex;

            if (e.RowIndex >= 0)
            {
                // Buttons
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                
                // Get the currently selected data
                id = row.Cells["ID"].Value.ToString();
                title = row.Cells["Book title"].Value.ToString();
                author = row.Cells["Author"].Value.ToString();
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Update edit = new Update();
            edit.ShowDialog();

            // Magic!
            data.loadAllBooks();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();

            // Magic!
            data.loadAllBooks();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

    }
}
