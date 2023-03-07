using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LibrarySystem
{
    class DataHelper
    {
        private string conString;
        private DataGridView dataGrid;

        public DataHelper(string con, DataGridView dataGrid)
        {
            this.conString = con;
            this.dataGrid = dataGrid;
        }

        public void loadBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
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

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

        public void loadAvailableBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    // Retrieve only the available books
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books WHERE available = 1";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

        public void loadBorrowedBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    // Retrieve only the available books
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books WHERE available = 0";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

        public void loadAllBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    // Retrieve only the available books
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

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

        public void searchBooks(String searchQuery)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books WHERE title LIKE @search";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " Cannot perform the operation!");
            }
        }

        public void searchBooks(String searchQuery, String availability)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books WHERE title LIKE @search AND  available = @available";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
                    cmd.Parameters.AddWithValue("@available", "%" + availability + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " Cannot perform the operation!");
            }
        }

        // Data Manipulation
        public void updateBook(string book_id, string availability)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "UPDATE tbl_books SET available = @availability WHERE id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@availability", availability);
                    cmd.Parameters.AddWithValue("@id", book_id);
                    cmd.ExecuteNonQuery();

                    applyGridStyling();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");
            }
        }

        // UI Styling
        private void applyGridStyling()
        {
            // UI styling of data grid
            // Prevent dataGrid from rolling back to default header sizing when searching
            dataGrid.Columns[0].Width = 60;
            dataGrid.Columns[2].Width = 140;
            dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
