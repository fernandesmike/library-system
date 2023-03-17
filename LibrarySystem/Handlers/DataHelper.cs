using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace LibrarySystem
{
    /*
    ==========================================================================================================
    DataHelper class handles all the query the system may perform
        
    Whenever we instantiate a DataHelper class, we must always pass the connection string and 
    the reference to the data grid as an argument

    NOTE:
    We do have a different constuctor that will only accept a connection string this will only 
    useful whenever we try to instantiate a DataHelper class inside a Form that doesn't contain a data grid
    ==========================================================================================================
    */

    class DataHelper
    {
        private string conString;
        private DataGridView dataGrid;

        private int queryPerformed;

        /*
        =================
        Constructors
        =================
        */


        public DataHelper(string con)
        {
            this.conString = con;
        }

        public DataHelper(string con, DataGridView dataGrid)
        {
            this.conString = con;
            this.dataGrid = dataGrid;
        }

      
        /*
        =============================
        Book Data Query Language
        =============================
        */


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
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author, available AS Available FROM tbl_books WHERE title LIKE @search OR author LIKE @search";
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

        // Count books by the specified availability
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

        public int checkIfBookExist(string title, string author)
        {
            int result;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT COUNT(*) FROM tbl_books WHERE LOWER(title) = LOWER(@title) AND LOWER(author) = LOWER(@author)";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.ExecuteNonQuery();

                    result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error connecting to our server!");
                return 0;
            }
        }
        
        
        /*
        =================================
        Book Data Manipulation Language
        =================================
        */


        public int addBook(string title, string author)
        {
            // Split authors
            // string[] authorsList = author.Split(',');

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string command = "INSERT INTO tbl_books(book_id, title, author) VALUES (NEXT VALUE FOR sequence_id, @title, @author)";

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error adding the book!");
                return 0;
            }
        }

        public int updateBook(string book_id, string title, string author)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "UPDATE tbl_books SET title = @title, author = @author WHERE book_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@id", book_id);
                    queryPerformed = cmd.ExecuteNonQuery();

                    //applyGridStyling();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");
                return 0;
            }
        }

        public int updateBookStatus(string book_id, string availability)
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
                    queryPerformed = cmd.ExecuteNonQuery();

                    //applyGridStyling();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");
                return 0;
            }
        }

        public int deleteBook(string id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "DELETE from tbl_books WHERE book_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");
                return 0;
            }
        }


        /*
        ==============================
        Borrowers Data Query Language
        ==============================
        */


        public void loadBorrowers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT borrower_id AS 'Borrower ID', firstname AS Firstname, lastname AS Lastname, status AS Status FROM tbl_borrower";
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
                    string command = "SELECT borrower_id AS 'Borrower ID', firstname AS Firstname, lastname AS Lastname, status AS Status FROM tbl_borrower WHERE status = @status";
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
                    string command = "SELECT borrower_id AS 'Borrower ID', firstname AS Firstname, lastname AS Lastname, status AS Status FROM tbl_borrower WHERE firstname LIKE @search OR lastname LIKE @search";
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

        public int checkIfBorrowerExist(string firstname, string lastname)
        {
            int result;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT COUNT(*) FROM tbl_borrower WHERE LOWER(firstname) = LOWER(@firstname) AND LOWER(lastname) = LOWER(@lastname)";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.ExecuteNonQuery();

                    result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error connecting to our server!");
                return 0;
            }
        }


        /*
        ======================================
        Borrowers Data Manipulation Language
        ======================================
        */


        public int addBorrower(string firstName, string lastName)
        {
            int queryPerformed;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string command = "INSERT INTO tbl_borrower(borrower_id, firstname, lastname) VALUES (NEXT VALUE FOR sequence_id, @fName, @lName)";

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@fName", firstName);
                    cmd.Parameters.AddWithValue("@lName", lastName);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error creating your account!");
                return 0;
            }
        }

        public int updateBorrowerFirstName(string id, string firstName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "UPDATE tbl_borrower SET firstname = @fName WHERE borrower_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@fName", firstName);
                    cmd.Parameters.AddWithValue("@id", id);
                    queryPerformed = cmd.ExecuteNonQuery();

                    //applyGridStyling();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");
                return 0;
            }
        }

        public int updateBorrowerLastName(string id, string lastName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "UPDATE tbl_borrower SET lastname = @lName WHERE borrower_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@fName", lastName);
                    cmd.Parameters.AddWithValue("@id", id);
                    queryPerformed = cmd.ExecuteNonQuery();

                    //applyGridStyling();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");
                return 0;
            }
        }

        public int updateBorrowerName(string id, string firstName, string lastName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "UPDATE tbl_borrower SET firstname = @fName, lastname = @lName WHERE borrower_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@fName", firstName);
                    cmd.Parameters.AddWithValue("@lName", lastName);
                    cmd.Parameters.AddWithValue("@id", id);
                    queryPerformed = cmd.ExecuteNonQuery();

                    //applyGridStyling();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");
                return 0;
            }
        }

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
        
        public int deleteBorrower(string id)
        {
            int queryPerformed;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "DELETE from tbl_borrower WHERE borrower_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");

                return 0;
            }
        }


        /*
        ============
        UI Styling
        ============
        */


        private void applyGridStyling()
        {
            // Refresh the grid
            dataGrid.Visible = false;
            dataGrid.Visible = true;
        }
    }
}
