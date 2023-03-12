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

        // For screens with no data grids
        public DataHelper(string con)
        {
            this.conString = con;
        }

        public DataHelper(string con, DataGridView dataGrid)
        {
            this.conString = con;
            this.dataGrid = dataGrid;
        }


        // Books - DQL //

        public void loadAllBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    // Retrieve only the available books
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author, available AS Available FROM tbl_books";
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
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author, available AS Available FROM tbl_books WHERE available = 1";
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
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author, available AS Available FROM tbl_books WHERE available = 0";
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

        public void searchBooks(string searchQuery)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author, available AS Available FROM tbl_books WHERE title LIKE @search";
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

        public void searchBooks(string searchQuery, string availability)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author, available AS Available FROM tbl_books WHERE title LIKE @search AND  available = @available";
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

        public int countBooks()
        {
            int count;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT COUNT(*) FROM tbl_books";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
                return 0;
            }

        }

        public int countBooks(string available)
        {
            int count;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT COUNT(*) FROM tbl_books WHERE available = @available";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@available", available);
                    cmd.ExecuteNonQuery();

                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
                return 0;
            }

        }

        // Books - DML //

        public void updateBookStatus(string book_id, string availability)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "UPDATE tbl_books SET available = @availability WHERE book_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@availability", availability);
                    cmd.Parameters.AddWithValue("@id", book_id);
                    cmd.ExecuteNonQuery();

                    //applyGridStyling();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");
            }
        }

        public void loadBorrowers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT borrower_id AS 'Borrower ID', username AS Username, firstname AS Firstname, lastname AS Lastname, status AS Status FROM tbl_borrower";
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

        public void loadBorrowers(string status)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT borrower_id AS 'Borrower ID', username AS Username, firstname AS Firstname, lastname AS Lastname, status AS Status FROM tbl_borrower WHERE status = @status";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@status", status);
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

        public void searchBorrowers(String searchQuery)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT borrower_id AS 'Borrower ID', username AS Username, firstname AS Firstname, lastname AS Lastname, status AS Status FROM tbl_borrower WHERE firstname LIKE @search OR lastname LIKE @search";
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

        // Borrowers - DQL //

        public int countBorrowers()
        {
            int count;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT COUNT(*) FROM tbl_borrower";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
                return 0;
            }

        }

        public int countBorrowers(string status)
        {
            int count;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT COUNT(*) FROM tbl_borrower WHERE status = @status";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();

                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
                return 0;
            }

        }

        // Borrowers - DML //

        public void changeBorrowerStatus(string borrower_id, string changeTo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "UPDATE tbl_borrower SET status = @status WHERE borrower_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@status", changeTo);
                    cmd.Parameters.AddWithValue("@id", borrower_id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");
            }
        }
        
        public void deleteBorrower(string id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "DELETE from tbl_borrower WHERE borrower_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
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
            // Refresh the grid
            dataGrid.Visible = false;
            dataGrid.Visible = true;
        }
    }
}
