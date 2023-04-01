using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Repository
{
    class BookRepository : IRepository
    {
        private readonly string connection;
        private readonly DataGridView dataGrid;

        private int queryPerformed;

        private List<string> bookDetails;

        public BookRepository(string connection)
        {
            this.connection = connection;
            this.bookDetails = new List<string>();
        }

        public BookRepository(string connection, DataGridView dataGrid)
        {
            this.connection = connection;
            this.dataGrid = dataGrid;
            this.bookDetails = new List<string>();
        }


        // DATA QUERY LANGUAGE

        public void loadAll()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT book_id AS ID, " +
                                     "book_title AS [Book title], " +
                                     "book_author AS Author, " +
                                     "book_quantities AS [Total copies], " +
                                     "date_added AS [Added last], " +
                                     "book_status AS Status " +
                                     "FROM tbl_book";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.ExecuteNonQuery();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        using (DataTable books = new DataTable())
                        {
                            adapter.Fill(books);
                            dataGrid.DataSource = books;
                        }
                    }

                    refreshDataGrid();
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + "There was a problem loading books");
            }
        }

        public void loadBorrowed(int borrowerId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT tbl_borrow_book.borrow_id AS [Transaction ID], " +
                                     "CONCAT(tbl_book.book_title, ' by ', tbl_book.book_author) AS Book, " +
                                     "tbl_borrow_book.quantities_borrowed AS [Borrowed copies], " +
                                     "tbl_borrow_book.date_borrowed AS [Borrowed on], " +
                                     "tbl_borrow_book.date_deadline AS Deadline " +
                                     "FROM tbl_book " +
                                     "INNER JOIN tbl_borrow_book ON tbl_borrow_book.book_id = tbl_book.book_id " +
                                     "INNER JOIN tbl_borrower ON tbl_borrow_book.borrower_id = tbl_borrower.borrower_id " +
                                     "WHERE tbl_borrow_book.borrower_id = @borrowerId";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@borrowerId", borrowerId);
                        cmd.ExecuteNonQuery();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        using (DataTable books = new DataTable())
                        {
                            adapter.Fill(books);
                            dataGrid.DataSource = books;
                        }
                    }

                    refreshDataGrid();
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + "There was a problem loading books");
            }
        }

        public void loadActive()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    // TODO: Try to use enums for status here
                    string command = "SELECT book_id AS ID, " +
                                     "book_title AS [Book title], " +
                                     "book_author AS Author, " +
                                     "book_quantities AS [Total copies], " +
                                     "date_added AS [Added last], " +
                                     "book_status AS Status " +
                                     "FROM tbl_book " +
                                     "WHERE book_status = 1";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.ExecuteNonQuery();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        using (DataTable books = new DataTable())
                        {
                            adapter.Fill(books);
                            dataGrid.DataSource = books;
                        }
                    }

                    refreshDataGrid();
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + "There was a problem loading active books");
            }
        }

        public void loadInactive()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    // TODO: Try to use enums for status here
                    string command = "SELECT book_id AS ID, " +
                                     "book_title AS [Book title], " +
                                     "book_author AS Author, " +
                                     "book_quantities AS [Total copies], " +
                                     "date_added AS [Added last], " +
                                     "book_status AS Status " +
                                     "FROM tbl_book " +
                                     "WHERE book_status = 0";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.ExecuteNonQuery();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        using (DataTable books = new DataTable())
                        {
                            adapter.Fill(books);
                            dataGrid.DataSource = books;
                        }
                    }

                    refreshDataGrid();
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + "There was a problem loading inactive books");
            }

        }

        public void loadAvailable()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    // TODO: Try to use enums for status here
                    string command = "SELECT book_id AS ID, " +
                                     "book_title AS [Book title], " +
                                     "book_author AS Author, " +
                                     "book_quantities AS [Available copies] " +
                                     "FROM tbl_book " +
                                     "WHERE book_status = 1 " +
                                     "AND book_quantities > 0";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.ExecuteNonQuery();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        using (DataTable books = new DataTable())
                        {
                            adapter.Fill(books);
                            dataGrid.DataSource = books;
                        }
                    }

                    refreshDataGrid();
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + "There was a problem loading available books");
            }
        }

        public int count()
        {
            int count;

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT COUNT(*) FROM tbl_book";
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

        public int countByStatus(int status)
        {
            int count;

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT COUNT(*) FROM tbl_book WHERE book_status = @status";
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

        public bool checkIfExist(string title, string author)
        {
            int result = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT COUNT(*) " +
                                     "FROM tbl_book " +
                                     "WHERE LOWER(book_title) = LOWER(@title) " +
                                     "AND LOWER(book_author) = LOWER(@author)";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.ExecuteNonQuery();

                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error connecting to our server!");
            }

            return result > 0 ? true : false;

        }

        public void search(string searchQuery)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT book_id AS ID, " +
                                     "book_title AS [Book title], " +
                                     "book_author AS Author, " +
                                     "book_quantities AS [Total copies], " +
                                     "date_added AS [Added last], " +
                                     "book_status AS Status " +
                                     "FROM tbl_book " +
                                     "WHERE book_title LIKE @search " +
                                     "OR book_author LIKE @search";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }
                    refreshDataGrid();
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + " Cannot perform the operation!");
            }
        }

        public List<string> getTransactionDetails(int transactionId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT tbl_book.book_title AS title, " +
                                     "tbl_book.book_author AS author, " +
                                     "tbl_borrow_book.date_borrowed, " +
                                     "tbl_borrow_book.date_deadline, " +
                                     "tbl_borrow_book.quantities_borrowed AS quantities " +
                                     "FROM tbl_book " +
                                     "INNER JOIN tbl_borrow_book ON tbl_borrow_book.book_id = tbl_book.book_id " +
                                     "WHERE tbl_borrow_book.borrow_id = @transacId";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@transacId", transactionId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    bookDetails.Add(reader[i].ToString());
                                }
                            }
                        }
                    }

                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + "There was a problem retrieving book details");
            }

            return bookDetails;
        }

        // DATA MANIPULATION LANGUAGE

        public int add(string title, string author, string dateAdded, int quantities)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string command = "INSERT INTO tbl_book(book_id, book_title, book_author, date_added, book_quantities) " +
                                     "VALUES (NEXT VALUE FOR seq_book_id, @title, @author, @date, @quantities)";

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@date", dateAdded);
                    cmd.Parameters.AddWithValue("@quantities", quantities);
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

        public int update(string bookId, string title, string author, int quantities)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "UPDATE tbl_book " +
                                     "SET book_title = @title, " +
                                     "book_author = @author, " +
                                     "book_quantities = @quantities " +
                                     "WHERE book_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@id", bookId);
                    cmd.Parameters.AddWithValue("@quantities", quantities);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error updating the book!");
                return 0;
            }
        }

        public int delete(string id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "DELETE from tbl_book WHERE book_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + "There was an error deleting the book");
                return 0;
            }
        }

        public int updateStatus(string bookId, int status)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "UPDATE tbl_book " +
                                     "SET book_status = @status " +
                                     "WHERE book_id = @id";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", bookId);
                        queryPerformed = cmd.ExecuteNonQuery();
                    }

                    return queryPerformed;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error updating the book status");
                return 0;
            }
        }

        public int increaseQuantity(int bookId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "UPDATE tbl_book " +
                                     "SET book_quantities = book_quantities + 1 " +
                                     "WHERE book_id = @bookId ";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        queryPerformed = cmd.ExecuteNonQuery();
                    }

                    refreshDataGrid();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error updating the book quantity");
                return 0;
            }

        }

        public int increaseQuantity(int bookId, int increaseAmount)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "UPDATE tbl_book " +
                                     "SET book_quantities = book_quantities + @increaseAmt " +
                                     "WHERE book_id = @bookId ";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        cmd.Parameters.AddWithValue("@increaseAmt", increaseAmount);
                        queryPerformed = cmd.ExecuteNonQuery();
                    }

                    refreshDataGrid();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error updating the book quantity");
                return 0;
            }

        }

        public int decreaseQuantity(int bookId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "UPDATE tbl_book " +
                                     "SET book_quantities = book_quantities - 1 " +
                                     "WHERE book_id = @bookId ";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        queryPerformed = cmd.ExecuteNonQuery();
                    }

                    refreshDataGrid();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error updating the book quantity");
                return 0;
            }

        }

        public int decreaseQuantity(int bookId, int decreaseAmount)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "UPDATE tbl_book " +
                                     "SET book_quantities = book_quantities - @decreaseAmt " +
                                     "WHERE book_id = @bookId ";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        cmd.Parameters.AddWithValue("@decreaseAmt", decreaseAmount);
                        queryPerformed = cmd.ExecuteNonQuery();
                    }

                    refreshDataGrid();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error updating the book quantity");
                return 0;
            }

        }

        public int updateQuantity(int bookId, int bookQuantity)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "UPDATE tbl_book " +
                                     "SET book_quantities = @newQuantity " +
                                     "WHERE book_id = @bookId ";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        cmd.Parameters.AddWithValue("@newQuantity", bookQuantity);
                        queryPerformed = cmd.ExecuteNonQuery();
                    }

                    refreshDataGrid();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error updating the book quantity");
                return 0;
            }

        }


        // MISC

        public void refreshDataGrid()
        {
            dataGrid.Visible = false;
            dataGrid.Visible = true;
        }

    }
}


/*
loadBorrowed
getBookDetails
getBookID

updateBookDetails

*/
