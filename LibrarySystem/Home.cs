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
    public partial class Home : Form
    {
        private string connectionString;

        // Static variables used to extract data to other forms
        public static string id;
        public static string title;
        public static string author;

        public Home()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Greet the user
            lblUser.Text = "Welcome, " + Login.currentUser + "!";

            // Populate the data grid everytime the form loads
            loadData();
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
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books WHERE title LIKE @search";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    // UI styling of data grid
                    // Prevent dataGrid from rolling back to default header sizing when searching
                    dataGrid.Columns[0].Width = 60;
                    dataGrid.Columns[2].Width = 140;
                    dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " Cannot perform the operation!");
            }
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
                        loadData();

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
            loadData();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();

            // Magic!
            loadData();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void loadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    // UI styling of data grid
                    dataGrid.Columns[0].Width = 60;
                    dataGrid.Columns[2].Width = 140;
                    dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

    }
}
